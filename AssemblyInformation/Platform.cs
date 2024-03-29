using System;
using System.IO;
#if !NET40
using System.Reflection;
#endif
using System.Runtime.InteropServices;

namespace AssemblyInformation 
{
    // ReSharper disable InconsistentNaming
    public enum MachineType : ushort 
    {
        IMAGE_FILE_MACHINE_UNKNOWN = 0x0,
        IMAGE_FILE_MACHINE_AM33 = 0x1d3,
        IMAGE_FILE_MACHINE_AMD64 = 0x8664,
        IMAGE_FILE_MACHINE_ARM = 0x1c0,
        IMAGE_FILE_MACHINE_EBC = 0xebc,
        IMAGE_FILE_MACHINE_I386 = 0x14c,
        IMAGE_FILE_MACHINE_IA64 = 0x200,
        IMAGE_FILE_MACHINE_M32R = 0x9041,
        IMAGE_FILE_MACHINE_MIPS16 = 0x266,
        IMAGE_FILE_MACHINE_MIPSFPU = 0x366,
        IMAGE_FILE_MACHINE_MIPSFPU16 = 0x466,
        IMAGE_FILE_MACHINE_POWERPC = 0x1f0,
        IMAGE_FILE_MACHINE_POWERPCFP = 0x1f1,
        IMAGE_FILE_MACHINE_R4000 = 0x166,
        IMAGE_FILE_MACHINE_SH3 = 0x1a2,
        IMAGE_FILE_MACHINE_SH3DSP = 0x1a3,
        IMAGE_FILE_MACHINE_SH4 = 0x1a6,
        IMAGE_FILE_MACHINE_SH5 = 0x1a8,
        IMAGE_FILE_MACHINE_THUMB = 0x1c2,
        IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x169,
    }
    // ReSharper restore InconsistentNaming

    // Taken from .NET Framework versions newer than 4.0 to add support for Preferred32Bit.
    /// <summary>
    /// Identifies the nature of the code in an executable file.
    /// </summary>
    [Serializable]
    [Flags]
    [ComVisible(true)]
    public enum PortableExecutableKindsNew
    {
        /// <summary>
        /// The file is not in portable executable (PE) file format.
        /// </summary>
        NotAPortableExecutableImage = 0,
        /// <summary>
        /// The executable contains only Microsoft intermediate language (MSIL), and
        ///     is therefore neutral with respect to 32-bit or 64-bit platforms.
        /// </summary>
        ILOnly = 1,
        /// <summary>
        /// The executable can be run on a 32-bit platform, or in the 32-bit Windows
        ///     on Windows (WOW) environment on a 64-bit platform.
        /// </summary>
        Required32Bit = 2,
        /// <summary>
        /// The executable requires a 64-bit platform.
        /// </summary>
        PE32Plus = 4,
        /// <summary>
        /// The executable contains pure unmanaged code.
        /// </summary>
        Unmanaged32Bit = 8,
        /// <summary>
        /// The executable is platform-agnostic but should be run on a 32-bit platform whenever
        ///     possible.
        /// </summary>
        Preferred32Bit = 16,
    }

    // Taken from .NET Framework versions newer than 4.0 to add support for ARM.
    /// <summary>
    /// Identifies the platform targeted by an executable.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public enum ImageFileMachineNew
    {
        /// <summary>
        /// Targets a 32-bit Intel processor.
        /// </summary>
        I386 = 332,
        /// <summary>
        /// Targets an ARM processor.
        /// </summary>
        ARM = 452,
        /// <summary>
        /// Targets a 64-bit Intel processor.
        /// </summary>
        IA64 = 512,
        /// <summary>
        /// Targets a 64-bit AMD processor.
        /// </summary>
        AMD64 = 34404,
    }

    class Platform 
    {
        // Adapted from https://stackoverflow.com/a/6309893
        public static bool IsAssembly(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var br = new BinaryReader(fs))
                {
                    byte[] header = br.ReadBytes(2); // Read MZ
                    if (header[0] != (byte)'M' && header[1] != (byte)'Z')
                        return false;

                    fs.Seek(64 - 4, SeekOrigin.Begin); // Read elf_new this is the offset where the IMAGE_NT_HEADER begins
                    int offset = br.ReadInt32();
                    fs.Seek(offset, SeekOrigin.Begin);
                    header = br.ReadBytes(2);
                    if (header[0] != (byte)'P' && header[1] != (byte)'E')
                        return false;

                    fs.Seek(20, SeekOrigin.Current); // Point to last word of IMAGE_FILE_HEADER
                    short readInt16 = br.ReadInt16();
                    return (readInt16 & 0x2000) == 0x2000 || (readInt16 & 0x0002) == 0x0002; // True when this is a DLL or an EXE.
                }
            }
        }

        public static MachineType GetDllMachineType(string dllPath) 
        {
            //see http://www.microsoft.com/whdc/system/platform/firmware/PECOFF.mspx
            //offset to PE header is always at 0x3C
            //PE header starts with "PE\0\0" =  0x50 0x45 0x00 0x00
            //followed by 2-byte machine type field (see document above for enum)
            using (var fs = new FileStream(dllPath, FileMode.Open, FileAccess.Read)) 
            {
                using (var br = new BinaryReader(fs))
                {
                    fs.Seek(0x3c, SeekOrigin.Begin);
                    Int32 peOffset = br.ReadInt32();
                    fs.Seek(peOffset, SeekOrigin.Begin);
                    UInt32 peHead = br.ReadUInt32();
                    if (peHead != 0x00004550) // "PE\0\0", little-endian
                        throw new BadImageFormatException("Unable to determine the assembly's type. Can't find PE header");
                    var machineType = (MachineType)br.ReadUInt16();
                    return machineType;
                }
            }
        }

        /// <summary>
        /// returns true if the dll is 64-bit, false if 32-bit, and null if unknown
        /// </summary>
        public static bool? Is64BitAssembly(string dllPath) 
        {
            switch (GetDllMachineType(dllPath)) 
            {
                case MachineType.IMAGE_FILE_MACHINE_AMD64:
                case MachineType.IMAGE_FILE_MACHINE_IA64:
                    return true;
                case MachineType.IMAGE_FILE_MACHINE_I386:
                    return false;
                default:
                    return null;
            }
        }

        public static bool IsRunningAs64Bit 
        {
            get
            {
                #if !NET40
                Assembly currentAssembly = Assembly.GetCallingAssembly();
                PortableExecutableKinds kinds;
                ImageFileMachine imgFileMachine;
                currentAssembly.ManifestModule.GetPEKind(out kinds, out imgFileMachine);

                return kinds != PortableExecutableKinds.NotAPortableExecutableImage && (kinds & PortableExecutableKinds.PE32Plus) == PortableExecutableKinds.PE32Plus;
                #else
                return Environment.Is64BitProcess;
                #endif
            }
        }
    }
}

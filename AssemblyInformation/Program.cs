using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace AssemblyInformation
{
    class Program
    {
        public const string ApplicationPathx86 = "AssemblyInformation.exe";
        public const string ApplicationPathx64 = "AssemblyInformationx64.exe";

        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += ApplicationThreadException;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainTypeResolve;
            
            if (args.Length == 1)
            {
                string filePath = args.GetValue(0).ToString();

                if (!File.Exists(filePath))
                {
                    MessageBox.Show(string.Format(Resource.FileDoesNotExist, filePath), Resource.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Platform.IsAssembly(filePath))
                {
                    MessageBox.Show(string.Format(Resource.NotDotNetAssembly, filePath), Resource.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string assemblyullName = Path.GetFullPath(filePath);
                bool? is64Bit = Platform.Is64BitAssembly(filePath);
                bool filePathIs64Bit = (is64Bit.HasValue && is64Bit.Value);
                bool currentProcessIs64Bit = Platform.IsRunningAs64Bit;

                bool spanProcess = (currentProcessIs64Bit != filePathIs64Bit);

                try
                {
                    if (!spanProcess)
                    {
                        //required to change directory for loading referenced assemblies
                        Environment.CurrentDirectory = Path.GetDirectoryName(filePath);
                        Assembly assembly = Assembly.LoadFile(assemblyullName);

                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new FormMain(assembly));
                    }
                    else
                    {
                        if (filePathIs64Bit)
                        {
                            #if !NET40
                            if (!OSBitCheck.Is64BitOperatingSystem())
                            #else
                            if (!Environment.Is64BitOperatingSystem)
                            #endif
                            {
                                MessageBox.Show(Resource.BitnessMismatch, Resource.AppName,
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        string launchPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
                        Debug.Assert(launchPath != null);

                        string otherBitnessPath = Path.Combine(launchPath, currentProcessIs64Bit ? ApplicationPathx86 : ApplicationPathx64);

                        if(!File.Exists(otherBitnessPath))
                        {
                            MessageBox.Show(string.Format(Resource.FailedToLocateFile, otherBitnessPath), Resource.AppName,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        

                        var psi = new ProcessStartInfo();
                        psi.FileName = otherBitnessPath;
                        if (!assemblyullName.Contains(" "))
                            psi.Arguments = args[0];
                        else
                            psi.Arguments = string.Format("\"{0}\"", assemblyullName);
                        psi.UseShellExecute = true;
                        Process.Start(psi);
                    }
                }
                catch (Exception ex)
                {
                    //if try to load win32 binary, then it will throw BadImageFormat exception...
                    //which doesn't contain any HResult. So, just search for it.
                    if (ex.Message.Contains(Resource.NotDotNetAssemblyErrorMessage) || ex.Message.Contains("0x80131018"))
                    {
                        MessageBox.Show(string.Format(Resource.NotDotNetAssembly, filePath), Resource.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Resource.LoadError, ex.Message), Resource.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(Resource.UsageString, Resource.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static Assembly CurrentDomainTypeResolve(object sender, ResolveEventArgs args)
        {
            if (null != args && !String.IsNullOrEmpty(args.Name))
            {
                string[] parts = args.Name.Split(',');
                if (parts.Length > 0)
                {
                    string name = parts[0] + ".dll";
                    if (File.Exists(name))
                    {
                        try
                        {
                            return Assembly.LoadFile((new FileInfo(name)).FullName);
                        }
                        catch (ArgumentException) { }
                        catch (IOException) { }
                        catch (BadImageFormatException) { }
                    }
                }
            }
            return null;
        }

        static void ApplicationThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(string.Format(Resource.LoadError, e.Exception.Message), Resource.AppName, MessageBoxButtons.OK);
            Application.Exit();
        }
    }
}

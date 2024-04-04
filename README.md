# .NET Assembly Information

This is a fork and enhancement of the project originally hosted at [https://assemblyinformation.codeplex.com/](https://assemblyinformation.codeplex.com/) ([archive](https://web.archive.org/web/20171223025233/https://assemblyinformation.codeplex.com/) | [mirror](https://codeplexarchive.org/codeplex/project/AssemblyInformation)).

## Purpose
Adds a context menu option labeled ".NET Assembly Information" that is displayed when right-clicking EXE and DLL files. Selecting it will display build information if the file is a .NET assembly. At a glance you can see things such as the .NET version used, whether it was built in release or debug, references, and more. See the screenshots below for a better idea of the information offered.

## New Features in this Fork
1. Support for all versions of the .NET Framework (only 4.0 and below were supported before) and all versions of .NET Standard. .NET Core and .NET 5+ are still not supported, however.
2. Support for Windows versions as old as Windows 98 and Windows 2000. The program must be rebuilt against .NET Framework 2.0 for this and will only support analysis of .NET 1.x and 2.x assemblies.
3. Clarification when only the CLR (Common Language Runtime) version is able to be detected. Prior to this, it was incorrectly labeling the CLR version as a .NET Framework version.
4. Assembly Kind: Detection of the use of Preferred32Bit.
5. Target Processor: Detection of ARM.
6. Pressing Enter with an assembly selected in any of the bottom lists will open the assembly, functioning as an alternative to double-clicking.
7. Using a natively rendered menu bar.

## Build Instructions
1. Open AssemblyInformation.sln.
2. In the properties for the AssemblyInformationX86 project, change the Target Framework to .NET Framework 2.0.
3. Ensure that you are set to Release mode and Build.
4. In bin\Release create a new subfolder named NET20 and copy AssemblyInformat.exe into it.
5. In the properties for the AssemblyInformationX86 project, change the Target Framework back to .NET Framework 4.0 Client Profile.
6. Ensure that you are set to Release mode and Build.
7. Open AssemblyInformationSetup.sln in Visual Studio 2005 and build. This will create the installers in the Setup folder.

## Screenshots
![Context Menu](readme/contextMenu.png)

![Main Window](readme/mainWindow.png)
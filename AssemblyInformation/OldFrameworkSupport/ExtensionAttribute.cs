// LINQBridge 1.3
// https://code.google.com/archive/p/linqbridge/

#if !NET35
namespace System.Runtime.CompilerServices
{
    /// <remarks>
    /// This attribute allows us to define extension methods without 
    /// requiring .NET Framework 3.5. For more information, see the section,
    /// <a href="http://msdn.microsoft.com/en-us/magazine/cc163317.aspx#S7">Extension Methods in .NET Framework 2.0 Apps</a>,
    /// of Basic Instincts: Extension Methods column in MSDN Magazine, issue Nov 2007.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly)]
    internal sealed class ExtensionAttribute : Attribute { }
}
#endif

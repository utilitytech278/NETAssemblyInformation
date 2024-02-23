// Taken from the .NET Framework reference source.

#if !NET40
namespace System.Runtime.Versioning
{
    /// <summary>
    /// Identifies the version of the .NET Framework that a particular assembly was compiled
    ///     against.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    internal sealed class TargetFrameworkAttribute : Attribute
    {
        private string _frameworkName;  // A target framework moniker
        private string _frameworkDisplayName;

        /// <summary>
        /// Initializes an instance of the System.Runtime.Versioning.TargetFrameworkAttribute
        ///     class by specifying the .NET Framework version against which an assembly was
        ///     built.
        /// </summary>
        /// <param name="frameworkName">The version of the .NET Framework against which the assembly was built.</param>
        /// <exception cref="ArgumentNullException">frameworkName is null.</exception>
        public TargetFrameworkAttribute(string frameworkName)
        {
            if (frameworkName == null)
                throw new ArgumentNullException("frameworkName");
            //Contract.EndContractBlock();
            _frameworkName = frameworkName;
        }

        /// <summary>
        /// Gets the name of the .NET Framework version against which a particular assembly
        ///     was compiled.
        /// </summary>
        /// <returns>The name of the .NET Framework version with which the assembly was compiled.</returns>
        public string FrameworkName
        {
            get { return _frameworkName; }
        }

        /// <summary>
        /// Gets the display name of the .NET Framework version against which an assembly
        ///     was built.
        /// </summary>
        /// <returns>The display name of the .NET Framework version.</returns>
        public string FrameworkDisplayName
        {
            get { return _frameworkDisplayName; }
            set { _frameworkDisplayName = value; }
        }
    }
}
#endif

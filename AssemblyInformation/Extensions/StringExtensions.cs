using System;

namespace AssemblyInformation
{
    internal static class StringExtensions
    {
        // Taken from the .NET Framework reference source.
        /// <summary>
        /// Indicates whether the specified string is null or an <see cref="String.Empty"/> string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return (value == null || value.Length == 0);
        }

        // Taken from the .NET Framework reference source.
        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or <see cref="String.Empty"/>, or if value consists exclusively of white-space characters.</returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            if (value == null)
            {
                return true;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsWhiteSpace(value[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

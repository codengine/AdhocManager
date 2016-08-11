using System;
using System.Reflection;

namespace AdhocManager
{
    internal class AssemblyUtils
    {
        public static string GetMajorMinorRevisionVersion(Assembly assembly)
        {
            return GetMajorMinorRevisionVersion(assembly.GetName().Version);
        }

        public static string GetMajorMinorRevisionVersion(Version version)
        {
            string[] parts =
            {
                version.Major.ToString(),
                version.Minor.ToString(),
                version.Revision.ToString()
            };

            return string.Join(".", parts);
        }
    }
}
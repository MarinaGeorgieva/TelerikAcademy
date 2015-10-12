/* Problem 11. Version attribute

Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime. */

namespace Problem11_VersionAttribute
{
    using System;

    class VersionAttribute : Attribute
    {
        [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
            AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
            AllowMultiple = false)]

        public class VersionAttribute : Attribute
        {
            private string version;

            public string Version
            {
                get 
                { 
                    return this.version; 
                }
                set 
                { 
                    this.version = value; 
                }
            }

            public VersionAttribute(string version)
            {
                this.Version = version;
            }
        }
    }
}

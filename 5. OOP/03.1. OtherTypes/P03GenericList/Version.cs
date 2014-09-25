namespace P03GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
        | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]
    public class Version : Attribute
    {
        public Version(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; private set; }

        public int Minor { get; private set; }
        
        public override string ToString()
        {
            return this.Major + "." + this.Minor;
        }
    }
}

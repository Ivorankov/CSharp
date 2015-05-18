
namespace Problem_11.Version_attribute
{
    using System;
    [AttributeUsage(AttributeTargets.Struct |
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Enum |
        AttributeTargets.Method ,
        AllowMultiple = false)]
   public class VersionAttribute : Attribute
    {
        private string version;

        public string Verson
        {
            get { return this.version; }
            set { this.version = value; }
        }
        public VersionAttribute(string version)
        {
            this.Verson = version;
        }
    }
}


namespace Problem_11.Version_attribute
{
    using System;
    [Version("2.11")]
    class VersonMain
    {
        static void Main(string[] args)
        {
            Type type = typeof(VersonMain);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attributes)
            {
                Console.WriteLine("Version: " + item.Verson);
            }
        }
    }
}

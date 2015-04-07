//Implement an extension method Substring(int index, int length) for the class StringBuilder
// that returns new StringBuilder and has the same functionality as Substring in the class String.
namespace Problem_01.Str
{
    using System;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder("CanFood");
            Console.WriteLine("We have a string builder containing {0}",test.ToString());

            var result = test.SubString(3);
            var result2 = test.SubString(0, 3);
            Console.WriteLine("First test - {0}", result);
            Console.WriteLine("Second test - {0}", result2);

        }
    }
    public static class Extentions
    {
        public static StringBuilder SubString(this StringBuilder str, int startIndex, int lenght)
        {
            StringBuilder resultStrB = new StringBuilder(str.ToString().Substring(startIndex, lenght));
            return resultStrB;
        }
        public static StringBuilder SubString(this StringBuilder str, int startIndex)
        {
            StringBuilder resultStrB = new StringBuilder(str.ToString().Substring(startIndex));
            return resultStrB;
        }
    }
}

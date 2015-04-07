namespace Problem_17____Longest_string
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            var strings = new string[] { "ImTheLongest!", "abv", "NO I am longer!111", "car" };

            var longestString =
                from stringg in strings
                where stringg.Length == strings.Max(x => x.Length)
                select stringg;
            foreach (var st in longestString)
            {
                Console.WriteLine(st);
            }
        }
    }
}

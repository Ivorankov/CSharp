using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Nightmare_on_Code_Street
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum,final;
            string user = Console.ReadLine();
            char[] tester = user.ToCharArray();
            sum = 0;
            int counter = 0;
            string nov = string.Empty;
            for (int x = 1; x < tester.Length; x = x + 2)
            {
                if (Char.IsDigit(tester[x]))
                {
                    nov = nov + tester[x];
                    counter++;
                }
            }
            long.TryParse(nov, out final);
            for (int y = 0; y <= nov.Length; y++)
            {
                sum = sum + final % 10;
                final /= 10;
            }
            Console.WriteLine(counter + " " + sum);
        }
    }
}
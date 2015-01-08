using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
namespace Print_Long_Sequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            int x, y, n;
            n = -5;
            for (x = 2; x <= 1000; x = x + 2)
            {
                y = x + n;
                n = n - 4;
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
        }
    }
}
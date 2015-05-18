using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
namespace Print_a_sequence
{
    class PrintaSequence
    {
        static void Main(string[] args)
        {
            int x,y,n;
            n = -5;
            for (x = 2; x <= 10; x = x + 2)
            {
                y = x + n;
                n = n - 4;
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
        }
    }
}

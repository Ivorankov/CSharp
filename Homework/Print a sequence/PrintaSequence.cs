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
            //x is used to create the sequence 2,4,6...the second part(-3,-5,-7...)is created using a simple math formula that subtracts from the value of x.This ensures that the siquence will be arranged accordingly when the program starts.
        }
    }
}

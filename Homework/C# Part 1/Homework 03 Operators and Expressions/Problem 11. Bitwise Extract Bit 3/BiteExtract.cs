using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
namespace Problem_11.Bitwise_Extract_Bit_3
{
    class BiteExtract
    {
        static void Main(string[] args)
        {
            int number,blank,newBit,finalBit;
            string bin;

            Console.WriteLine("This boring program finds a value of a bit #3 in a number");
            Console.Write("Write some number: ");
            number = Convert.ToInt32(Console.ReadLine());
            bin = Convert.ToString(number, 2);

            blank = 1 << 3;
            newBit = number & blank;
            finalBit = newBit >> 3;

            Console.WriteLine("This is what your number looks like in binary: " + bin);
            Console.WriteLine("This is the 3d to last bit: " + finalBit);
        }
    }
}

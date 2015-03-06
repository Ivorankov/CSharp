using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that extracts from given integer n the value of given bit at index p
namespace Problem_12.Extract_Bit_from_Integer
{
    class ExtractnBit
    {
        static void Main(string[] args)
        {
            int number,bitPosition, blank, newBit, finalBit;
            string bin;

            Console.WriteLine("This boring program finds a value of a any bit in a number");
            Console.Write("Write some number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which bit possition would you like to check: ");
            bitPosition = Convert.ToInt32(Console.ReadLine());
            bin = Convert.ToString(number, 2);

            blank = 1 << bitPosition;
            newBit = number & blank;
            finalBit = newBit >> bitPosition;

            Console.WriteLine("This is what your number looks like in binary: " + bin);
            Console.WriteLine("This is the bit's value: " + finalBit);
        }
    }
}

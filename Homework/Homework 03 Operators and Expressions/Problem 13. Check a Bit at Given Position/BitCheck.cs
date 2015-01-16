using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1
namespace Problem_13.Check_a_Bit_at_Given_Position
{
    class BitCheck
    {
        static void Main(string[] args)
        {
            int number, bitPosition, blank, newBit, finalBit;
            string bin;
            bool test;

            Console.WriteLine("This boring program checks if a value of a selected bit is 1");
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
            test = (finalBit == 1);
            if (test) 
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }
        }
    }
}

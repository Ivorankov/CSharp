using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
namespace Problem_14.Modify_a_Bit_at_Given_Position
{
    class ModifyBits
    {
        static void Main(string[] args)
        {
            int number, bitPosition, blank, newBit,bitValue;


            bitValue = 1;
            Console.WriteLine("This boring program finds a value of a bit in a number");
            Console.Write("Write some number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which bit possition would you like to modify to "+ bitValue + " ");
            bitPosition = Convert.ToInt32(Console.ReadLine());

            blank = bitValue << bitPosition;
            newBit = number ^ blank;

            Console.WriteLine("This is what your number looks like in binary: " + Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("This is the bit's value: " + Convert.ToString(newBit,2).PadLeft(16,'0'));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    //The first and the second sequence of bits may not overlap.
namespace Problem_16.Bit_Exchange__Advanced_
{
    class BitSwitcher
    {
        static void Main(string[] args)
        {
            int number, bitPosition, bitPosition2, blank, blank2, newBit, newBit2, pairOfBits, bitValue, bitValue2, i, area;

            Console.WriteLine("This program will switch the values of the bits you select"); // In this part the user inputs the values
            Console.Write("Write some number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please select the first bit: ");
            bitPosition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please select the 2nd bit: ");
            bitPosition2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now just specify the ammount of bits you want to switch the value of: ");
            area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("This is your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));

            for (i = area; i >= 0; i = i - 1)
            {
                if ((i + bitPosition > 32) || (i + bitPosition2 > 32))  // This will check if the selected numbers are within the desired scope 
                {
                    Console.WriteLine("The selected bits will overlap the number");
                    break;
                }
                else if ((i + bitPosition < 0) || (i + bitPosition2 < 0))
                {
                    Console.WriteLine("The selected bits will overlap the number");
                    break;
                }
                else
                {
                    blank = 1 << bitPosition + i;     // Creates a bit(..0001) and moves it to the position we want 
                    blank2 = 1 << bitPosition2 + i;
                    newBit = number & blank;       // Leaves the bit at the specifyed location unmodifyed
                    newBit2 = number & blank2;
                    bitValue2 = newBit >> bitPosition;// Moves the bit we wanted to the [0] position , I use it to compare the 2 bits
                    bitValue = newBit2 >> bitPosition2;
                    pairOfBits = blank | blank2; // This creates a new number where the only 1's are at the specifyed locations

                    if (bitValue2 == bitValue) // If the two bit's have equal values then theres no point of doing anything 
                    {

                    }
                    else   // If the bits are not equal then I use the ^ operator to change theyr values (from 0 to 1 and vise versa)
                    {
                        number = number ^ pairOfBits;
                    }
                }
            }
            Console.WriteLine("This is the new number:        " + Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Binary_to_decimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts binary to decimal");
            Console.Write("Write a binary number: ");
            string userInput = Console.ReadLine();
            long result;

            result = DecimalToBinary(userInput);
            Console.WriteLine("Your number in decimal is: " + result);
        }
        static long DecimalToBinary(string binaryInput)
        {
            double  y, z;
            int binaryDigit;
            long result = 0;
            long binary = long.Parse(binaryInput);
            for (int i = 0; i <= 31; i++)
            {
                z = Math.Pow(2, i);//This does 2^0,2^1...2^n
                binaryDigit = (int)binary % 10;//This gets the binary digit(0 or 1)
                y = z * binaryDigit;//This multiplys the digit with the 2^n
                result = result + (long)y;//And this just sums it up
                binary = binary / 10;
            }
            return result;
        }
    }
}

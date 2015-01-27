using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality
namespace Problem_14.Decimal_to_Binary_Number
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long userDecimal, y, binaryDigit, binaryRemainer;
            int x, z;
            string result = string.Empty;
            Console.WriteLine("This program converts decimal numbers to binary");

            //This part will validate the user input
            Console.Write("Write some decimal number: ");
            while (!long.TryParse(Console.ReadLine(), out userDecimal))
            {
                Console.WriteLine("Please use numeric values: ");
            }
            z = 2;
            binaryRemainer = userDecimal;
            //This for loop will run 32 times (it will work for 32bit binary numbers)
            for (x = 32; x >= 0; x = x - 1)
            {
                y = Convert.ToInt64(Math.Pow(z, x));//This creates 2^n
                if (userDecimal > y)
                {
                    binaryDigit = binaryRemainer / y;//This gives us the binary digit
                    binaryRemainer = userDecimal % y;
                    result = result + binaryDigit.ToString();//This puts all of the digits in a string
                }
            }
            Console.WriteLine("Your number in binary is = " + result);
        }
    }
}

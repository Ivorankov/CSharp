using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Decimal_to_binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            Console.WriteLine("This program converts decimal numbers to binary");

            //This part will validate the user input
            Console.Write("Write some decimal number: ");
            long userDecimal = long.Parse(Console.ReadLine());
            result = Binary(userDecimal);
            Console.WriteLine("Your number in binary is: " + result.PadLeft(32,'0'));
            
        }
        static string Binary(long decNumber)
        {
            long binaryRemainer = decNumber;
            long binaryDigit = 1;
            long y = 1;
            string result = string.Empty;
            for (int x = 31; x >= 0; x = x - 1)
            {
                y = Convert.ToInt64(Math.Pow(2, x));//This creates 2^n
                if (decNumber >= y)
                {
                    binaryDigit = binaryRemainer / y;//This gives us the binary digit
                    binaryRemainer = decNumber % y;
                    result = result + binaryDigit.ToString();//This puts all of the digits in a string
                }
            }
            return result;
        }
    }
}

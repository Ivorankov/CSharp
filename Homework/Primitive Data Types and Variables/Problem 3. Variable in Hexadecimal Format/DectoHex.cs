using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
// Use Windows Calculator to find its hexadecimal representation.
// Print the variable and ensure that the result is 254.
namespace Problem_3.Variable_in_Hexadecimal_Format
{
    class DectoHex
    {
        static void Main(string[] args)
        {
            int Dec = 254;
            string Hex = Dec.ToString("X");
            int AndbacktoDec = int.Parse(Hex, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("Here is the number 254 in hexadecimal format - "+Hex);
            Console.WriteLine("And just to make sure it all adds up heres " + Hex + " converted to decimal - " + AndbacktoDec);
        }
    }
}

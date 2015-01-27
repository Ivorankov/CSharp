using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality(cry)
namespace Problem_13.Binary_to_Decimal_Number
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int i, binaryDigit;
            double x, y, z;
            long result, binary;
            char[] testValidation;
            Console.WriteLine("This program converts binary to decimal");

            //This part validates the user input
        here:
            Console.Write("Write a binary number: ");
            while (!long.TryParse(Console.ReadLine(), out binary))//I TryPrase the input so i can validate it, otherwise the input will be enterted as a string and later Parsed to long...
            {

                Console.Write("Please use numeric values between 0 and 1: ");
            }
            testValidation = binary.ToString().ToCharArray();
            foreach (var c in testValidation)
            {
                if (c != 48 && c != 49)
                {
                    Console.WriteLine("Invalid binary number!(binary can only contain 1's or 0's");
                    goto here; //I know its bad practise but in this case it helps a lot with validation(which is not required! So please dont sanction me :) ) 
                }
            }

            result = 0;
            x = 2;

            //This for loop runs for the lenght of the binary number
            for (i = 0; i <= 31; i++)
            {
                z = Math.Pow(x, i);//This does 2^0,2^1...2^n
                binaryDigit = (int)binary % 10;//This gets the binary digit(0 or 1)
                y = z * binaryDigit;//This multiplys the digit with the 2^n
                result = result + (long)y;//And this just sums it up
                binary = binary / 10;
            }
            Console.WriteLine("The binary number in decimal format is = " + result);
        }
    }
}

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
            string userInput;
            char[] testValidation;
            bool test1,test2;
            Console.WriteLine("This program converts binary to decimal");

            //This part validates the user input
            test2 = true;
            do
            {
                Console.Write("Write a binary number: ");
                userInput = Console.ReadLine();
                if (long.TryParse(userInput, out binary))//First we see if it's a valid number
                {
                    test1 = true;
                    testValidation = userInput.ToCharArray();//Then we put the number in a char array
                    foreach (var c in testValidation)//And in this foreach we check every digit , if there are digits different then 0 or 1 it sets the bool test2 to false
                    {
                        if (c == 48 || c == 49)
                        {
                            test2 = true;
                        }
                        else
                        {
                            test2 = false;
                            break;
                        }
                    }
                }
                else// if we didnt get a valid number we set test2 to false
                {
                    test1 = false;
                }
             while (test1 == false || test2 == false)//here If one for the bools is false it loops back to do.
             {
                 Console.WriteLine("Invalid binary number!");
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


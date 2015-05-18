using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Put the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
namespace Problem_6.Four_Digit_Number
{
    class FourDigitFun
    {
        static void Main(string[] args)
        {
            char[] digits;
            string digi;
            int line;
            int calculation, sumOfdigits;
            bool test,test2;

            Console.WriteLine("The old switcheroo");
            do                                                                                
            {
                Console.Write("Please enter a 4 digit number: ");                                            //This part will validate the user input
                test = (Int32.TryParse(Console.ReadLine(), out line) && Convert.ToString(line).Length == 4);
                if (test)
                {

                }
                else
                {
                    Console.WriteLine("The number must contain 4 digits...and be a number");
                }


            } while (test == false);

            sumOfdigits = 0;                                                             // This part splits the digits and sums them  
            calculation = Convert.ToInt32(line);
            while (calculation != 0)
            {
                sumOfdigits += calculation % 10;
                calculation /= 10;
            }
            Console.WriteLine("");
            Console.WriteLine("The sum of the individual digits is: "+sumOfdigits);
            Console.WriteLine("");

            digi = Convert.ToString(line);                                             //As you can probably tell this coverts the number into an Array and moves the digits around
            digits = digi.ToCharArray();
            Console.WriteLine("And here's the switchie part");
            Console.WriteLine(digits[3] + "" + digits[2] + "" + digits[1] + "" + digits[0]);
            Console.WriteLine(digits[3] + "" + digits[0] + "" + digits[1] + "" + digits[2]);
            Console.WriteLine(digits[0] + "" + digits[2] + "" + digits[1] + "" + digits[3]);
        }
    }
}





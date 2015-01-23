using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
namespace Problem_04.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double number1, number2, number3;

            Console.WriteLine(@"This program will show the sign of the product of 3 numbers, whatever ""product"" means");
            //This part will validate the user input
            Console.Write("Write the first number: ");
            while(!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Write the first number: ");
            }
            Console.Write("Write the second number: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Write the second number: ");
            }
            Console.Write("Write the third number: ");
            while (!double.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Write the third number: ");
            }
            //This part will compare the numbers and print the result to the console
            if (number1 == 0 || number2 == 0 || number3 == 0) //If any of the numbers is 0 then its obvious it will be 0
            {
                Console.WriteLine("The product is 0... you dont say");
            }
            else if (number1 < 0 && number2 < 0 && number3 < 0)//If all of them are negative 
            {
                Console.WriteLine("The product has a (-) value");
            }
            else if (number1 > 0 && number2 > 0 && number3 > 0)//If all of them are possitive
            {
                Console.WriteLine("The product has a (+) value");
            }
            else if ((number1 < 0 && number2 < 0 & number3 > 0) | (number2 < 0 && number3 < 0 & number1 > 0) | (number3 < 0 && number1 < 0 & number2 > 0))//If two of the numbers are negative and one is possitve
            {
                Console.WriteLine("The product has a (+) value");
            }
            else if ((number1 > 0 && number2 > 0 & number3 < 0) | (number2 > 0 && number3 > 0 & number1 < 0) | (number3 > 0 && number1 > 0 & number2 < 0))//If two of the numbers are possitve and one is negative
            {
                Console.WriteLine("The product has a (-) value");
            }

        }
    }
}

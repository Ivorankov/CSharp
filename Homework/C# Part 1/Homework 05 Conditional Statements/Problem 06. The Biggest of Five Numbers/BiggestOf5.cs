using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the biggest of five numbers by using only five if statements.
namespace Problem_06.The_Biggest_of_Five_Numbers
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, number4, number5;

            Console.WriteLine("This program will do the obvious(tell you which number is the biggest)");
            Console.Write("Write the first number: ");
            //This part will validate the user input
            while (!double.TryParse(Console.ReadLine(), out number1))
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
            Console.Write("Write the forth number: ");
            while (!double.TryParse(Console.ReadLine(), out number4))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Write the forth number: ");
            }
            Console.Write("Write the fifth number: ");
            while (!double.TryParse(Console.ReadLine(), out number5))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Write the fifth number: ");
            }
            //This part will compare the numbers and print the result to console
            if (number1 >= number2 && number1 >= number3 && number1 >= number4 && number1 >= number5)//If the first is the biggest
            {
                Console.WriteLine(number1 + " is the biggest");
            }
            else if (number2 >= number1 && number2 >= number3 && number2 >= number4 && number2 >= number5)//If the second number is the biggest
            {
                Console.WriteLine(number2 + " is the biggest");
            }
            else if (number3 >= number1 && number3 >= number2 && number3 >= number4 && number3 >= number5)//If the third number is the biggest
            {
                Console.WriteLine(number3 + " is the biggest");
            }
            else if (number4 >= number1 && number4 >= number2 && number4 >= number3 && number4 >= number5)//If the forth number is the biggest
            {
                Console.WriteLine(number4 + " is the biggest");
            }
            else if (number5 >= number1 && number5 >= number2 && number5 >= number3 && number5 >= number4)//If the fifth number is the biggest
            {
                Console.WriteLine(number5 + " is the biggest");
            }
        }
    }
}

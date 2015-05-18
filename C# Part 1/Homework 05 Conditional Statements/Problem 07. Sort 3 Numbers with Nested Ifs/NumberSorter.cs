using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
namespace Problem_7.Sort_3_Numbers_with_Nested_Ifs
{
    class NumberSorter
    {
        static void Main(string[] args)
        {
            double number1, number2, number3;

            Console.WriteLine("This program will sort numbers in descending order");
            Console.Write("Enter the first number: ");
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
            //This part will compare the numbers and print them in console in decsending order 3,2,1....
            if (number1 > number2)
            {
                if (number2 > number3)
                {
                    Console.WriteLine(number1 + " " + number2 + " " + number3);
                }
                else if (number1 > number3)
                {
                    Console.WriteLine(number1 + " " + number3 + " " + number2);
                }
            }
            if (number2 > number1)
            {
                if (number1 > number3)
                {
                    Console.WriteLine(number2 + " " + number1 + " " + number3);
                }
                else if (number2 > number3)
                {
                    Console.WriteLine(number2 + " " + number3 + " " + number1);
                }
            }
            if (number3 > number1)
            {
                if (number1 > number2)
                {
                    Console.WriteLine(number3 + " " + number1 + " " + number2);
                }
                else if (number3 > number2)
                {
                    Console.WriteLine(number3 + " " + number2 + " " + number1);
                }
            }
        }
    }
}

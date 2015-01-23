using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the biggest of three numbers
namespace Problem_05.The_Biggest_of_3_Numbers
{
    class TheBiggestOf3
    {
        static void Main(string[] args)
        {
            double number1, number2, number3;

            Console.WriteLine("This program will do the obvious(tell you which number is the biggest)");
            Console.Write("Write the first number: ");
            //This part will validate the user input
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
            //This part will compare the numbers and print the result to console
            if(number1 > number2 && number1 > number3)//If the first is the biggest
            {
                Console.WriteLine(number1 + " is the biggest");
            }
            else if (number2 > number3 && number2 > number1)//If the second number is the biggest
            {
                Console.WriteLine(number2 + " is the biggest");
            }
            else if (number3 > number1 && number3 > number2)//If the third number is the biggest
            {
                Console.WriteLine(number3 + " is the biggest");
            }
            else if(number1 == number2 && number1 == number3)//If all the numbers are equal
            {
                Console.WriteLine("Umm Ummmm....my money is on they are equal");
            }
            //In case there are 2 equal numbers that are greater then the 3rd number
            else if (number1 == number2 && number2 > number3)
            {
                Console.WriteLine("Its a tie between " + number1 + " and " + number2);
            }
            else if (number2 == number3 && number2 > number1) 
            {
                Console.WriteLine("Its a tie between " + number2 + " and " + number3);
            }
            else if (number3 == number1  && number3 > number2) 
            {
                Console.WriteLine("Its a tie between " + number1 + " and " + number3);
            }

        }
    }
}

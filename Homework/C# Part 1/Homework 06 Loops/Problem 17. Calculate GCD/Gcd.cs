using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
namespace Problem_17.Calculate_GCD
{
    class Gcd
    {
        static void Main(string[] args)
        {
            int userInput1, userInput2, devisor;

            Console.WriteLine("This program finds the greatest common divisor, sadly only of two numbers");

            //This part validates the user input
            Console.WriteLine("Please enter the first number: ");
            while(!int.TryParse(Console.ReadLine(), out userInput1))
            {
                Console.WriteLine("Please use numeric values!: ");
            }
            Console.WriteLine("Please enter the second number: ");
            while (!int.TryParse(Console.ReadLine(), out userInput2))
            {
                Console.WriteLine("Please use numeric values!: ");
            }
            devisor = 0;
            //This while loop will run untill a remainer > 0 appears after division
            while (userInput2 != 0)
            {
                devisor = userInput1 % userInput2;
                userInput1 = userInput2;
                userInput2 = devisor;
            }
            Console.WriteLine("The greatest common divisor is" + userInput1);
        }
    }
}

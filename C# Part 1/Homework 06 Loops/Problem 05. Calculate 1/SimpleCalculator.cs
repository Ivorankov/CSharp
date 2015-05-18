using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.
namespace Problem_05.Calculate_1
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {

            int i, x, n;          
            BigInteger equation, factorial, power, sum;

            Console.WriteLine("This program runs 2 numbers thru an equation");

            //This part will validate the user input
            Console.Write("Please, enter the first number: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Please, use numeric values!:");
            }
            Console.Write("Please, enter the second number: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Please, use numeric values!:");
            }
            factorial = 1;
            sum = 0;

            //This for loop will run the numbers from 1 to n
            for (i = 1; i <= n; i++)
            {
                factorial = factorial * i;//This is for 1!...n!
                power = (BigInteger)Math.Pow(x,i);//This is for x^1..x^n
                equation = factorial / power;
                sum = sum + equation;//This is the sum without the (1 +...)
            }
            Console.WriteLine("{0:F5}",(1+sum));//This adds the missing (1 +..) and prints the result to console 
        }
    }
}

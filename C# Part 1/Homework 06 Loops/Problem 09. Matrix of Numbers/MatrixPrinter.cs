using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
namespace Problem_09.Matrix_of_Numbers
{
    class MatrixPrinter
    {
        static void Main(string[] args)
        {
            int userinput, i, x;

            Console.WriteLine("This program prints matrixes?");

            //This will validate the user input
            Console.Write("Choose the size of the matrix (1-20): ");
            while (!int.TryParse(Console.ReadLine(), out userinput) || userinput < 1 || userinput > 20)
            {
                Console.WriteLine("Please use numeric values between 1-20: ");
            }

            for (i = 1; i <= userinput; i++)//This loop runs for the amount of lines needed
            {
                for (x = i; x < i + userinput; x++)//This loop creates the lines of numbers
                {
                    Console.Write("{0}", x);//Console.Write prints every new number(x) on the same line
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
namespace Problem_06.Calculate_N_K
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            int n, k, i;
            BigInteger factorial1, factorial2, equation;

            Console.WriteLine("This program calculates 2 numbers...whole numbers, not decimal");

            //This part will validate the user input
            Console.Write("Please, enter the first number(n): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n >= 100)
            {
                Console.WriteLine("Please use numeric values, also n cannot be greater then 100: ");
            }
            Console.Write("Please, enter the second number(k): ");
            while (!int.TryParse(Console.ReadLine(), out k) || k > n)
            {
                Console.WriteLine("Please use numeric values, also k cannot be greater then (n): ");
            }
            factorial1 = 1;
            factorial2 = 1;
            equation = 1;
            //This for loop runs the numbers from 1 to n
            for (i = 1; i <= n; i++)
            {
                factorial1 = factorial1 * i;//This is for n!
                if (i <= k)//This if runs the numbers from 1 to k, after that factorial2 stops increasing
                {
                    factorial2 = factorial2 * i;//This is for x!
                }
                equation = factorial1 / factorial2;//This is n!/x!
            }
            Console.WriteLine(equation);
        }
    }
}

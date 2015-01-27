using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
//is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
namespace Problem_07.Calculate_NK
{
    class SimpleCalc3
    {
        static void Main(string[] args)
        {
            int n, k, q, i;
            BigInteger factorial1, factorial2, factorial3, equation;
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
            factorial3 = 1;
            equation = 1;
            q = n - k;
            //This for loop runs the numbers from 1 to n
            for (i = 1; i <= n; i++)
            {
                factorial1 = factorial1 * i;//This is for n!
                if (i <= k)//This if runs the numbers from 1 to k, after that factorial2 stops increasing
                {
                    factorial2 = factorial2 * i;//This is for x!
                }
                if (i <= q)
                {
                    factorial3 = factorial3 * i;//This is for (n-k)!
                }
                equation = factorial1 / (factorial2 * factorial3);//This is n!/x!*(n-k)!!
            }
            Console.WriteLine(equation);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula (2n!)/(n+1)!*n!
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

namespace Problem_08.Catalan_Numbers
{
    class CatalianNumbers
    {
        static void Main(string[] args)
        {

            int i, n;
            BigInteger equation, factorialN, factorialN2, factorialNPlus;

            Console.WriteLine("This program runs 2 numbers thru an equation");

            //This part will validate the user input
            Console.Write("Please, enter the first number: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 100)
            {
                Console.Write("Please, use numeric values between 1-100:");
            }
            factorialN = 1;
            factorialN2 = 1;
            factorialNPlus = 1;
            equation = 1;

            //This for loop will run the numbers from 1 to n
            for (i = 1; i <= n * 2; i++)
            {
                if (i <= n)
                {
                    factorialN = factorialN * i;//This is for 1!...n!
                }
                if (i <= n+1)
                {
                    factorialNPlus = factorialNPlus * i;
                }
                factorialN2 = factorialN2 * i;
                equation = factorialN2 / (factorialNPlus * factorialN);
            }
            Console.WriteLine("The equation result is: " + equation);
        }
    }
}

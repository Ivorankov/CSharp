using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
namespace Problem_18.Trailing_Zeroes_in_N
{
    class FactorialZeroChecker
    {
        static void Main(string[] args)
        {
            BigInteger factorial, factiral2;
            int i, userNumber, count;

            Console.WriteLine("This program will count the 0's in the end of a factorialed? number");
            Console.WriteLine("It works with huge numbers tho the large numbers take a while to calculate...");

            //This part will validate the user input
            Console.Write("Enter the number you wish to see the factorial of the...wait, WHAT?: ");
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Please use numeric values!: ");
            }
            Console.WriteLine();
            factorial = 1;
            count = 0;

            //This for loop creates the factorial of the number
            for (i = 1; i <= userNumber; i++)
            {
                factorial = factorial * i;
            }

            //This while loop runs for the ammount of times as there are 0's and yes it takes ages if the user enters 100000 and higher...
            while (factorial % 10 == 0)
            {
                factorial = factorial / 10;
                count++;
            }

            Console.WriteLine("Apparently there are " + count + " zeros");
        }
    }
}

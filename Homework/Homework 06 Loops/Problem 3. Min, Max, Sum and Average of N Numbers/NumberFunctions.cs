using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
namespace Problem_3.Min__Max__Sum_and_Average_of_N_Numbers
{
    class NumberFunctions
    {
        static void Main(string[] args)
        {

            string number = string.Empty;
            int userAmount;
            double min, max, average, sum;
            Console.WriteLine("This program does some math stuff");
            Console.Write("How many numbers will you be using, kind sir/madam?: ");

            //This part will validate the user input
            while (!int.TryParse(Console.ReadLine(), out userAmount) || userAmount < 1)
            {
                Console.WriteLine("Please use numeric values/you can't rly use 0 numbers!: ");
            }

            //This part will fill a double array using the user's input
            Console.WriteLine("Enter your numbers below, and please use numbers!");
            double[] userArray = new double[userAmount];
            userArray = userArray.Select(x => double.Parse(Console.ReadLine())).ToArray();

            //This is the magic of arrays at work
            min = userArray.Min();
            max = userArray.Max();
            sum = userArray.Sum();
            average = sum / userArray.Length;

            //This prints the result to console
            Console.WriteLine("The min number is: " + min);
            Console.WriteLine("The max number is: " + max);
            Console.WriteLine("The sum of the numbers is: " + sum);
            Console.WriteLine("The average of the lot is: {0:F2}" ,average);
        }
    }
}

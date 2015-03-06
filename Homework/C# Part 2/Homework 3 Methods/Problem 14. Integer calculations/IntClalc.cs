using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
namespace Problem_14.Integer_calculations
{
    class IntClalc
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[] { };
            Console.WriteLine("This program does many many math stuff");

            //This part lets the user fill an array of ints
            Console.Write("Please enter some int numbers using (space) between each: ");
            userArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            //This part calls the methods and prints the result in the console
            Console.WriteLine("The lowest number is: {0}", MinOfNumbers(userArray));
            Console.WriteLine("The highest number is: {0}", MaxOfNumbers(userArray));
            Console.WriteLine("The average of the numbers is: {0}", AverageOfNumbers(userArray));
            Console.WriteLine("The product of the numbers is: {0}", ProductOfNumbers(userArray));

        }
        static int MinOfNumbers(int[] array)
        {
            int minNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minNumber > array[i])
                {
                    minNumber = array[i];
                }
            }
            return minNumber;
        }
        static int MaxOfNumbers(int[] array)
        {
            int maxNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                }
            }
            return maxNumber;
        }
        static decimal AverageOfNumbers(int[] array)
        {
            decimal average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];

            }
            average /= array.Length;
            return average;
        }
        static int SumOfNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int ProductOfNumbers(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}

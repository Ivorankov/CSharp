using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).
namespace Problem_15.Number_calculations
{
    class Calc
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[] { };
            Console.WriteLine("This program does many many math stuff");

            //This part lets the user fill an array of ints
            Console.Write("Please enter some int numbers using (space) between each: ");
            userArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            //This part calls the methods and prints the result in the console
            Console.WriteLine("The lowest number is: {0}", MinOfNumbers<int>(userArray));//in the <> brackets the data type is set, its left to int because user input's ints 
            Console.WriteLine("The highest number is: {0}", MaxOfNumbers<int>(userArray));
            Console.WriteLine("The average of the numbers is: {0}", AverageOfNumbers<int>(userArray));
            Console.WriteLine("The product of the numbers is: {0}", ProductOfNumbers<int>(userArray));

        }
        static T MinOfNumbers<T>(params T[] array)// This is the only difference...
        {
            dynamic minNumber = array[0];//Ow and the result's are dynamic (get set at runtime depending on the type of data used)
            for (int i = 1; i < array.Length; i++)
            {
                if (minNumber > array[i])
                {
                    minNumber = array[i];
                }
            }
            return minNumber;
        }
        static T MaxOfNumbers<T>(params T[] array)
        {
            dynamic maxNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                }
            }
            return maxNumber;
        }
        static T AverageOfNumbers<T>(params T[] array)
        {
            dynamic average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];

            }
            average /= array.Length;
            return average;
        }
        static T SumOfNumbers<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static T ProductOfNumbers<T>(params T[] array)
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}

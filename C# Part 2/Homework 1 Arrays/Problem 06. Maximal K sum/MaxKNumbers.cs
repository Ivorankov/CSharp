using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum
namespace Problem_06.Maximal_K_sum
{
    class MaxKNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program finds the max sum of a chosen ammount of array elements");

            //This part takes the user input
            Console.Write("How many numbers would you like to put in the array?: ");
            int userAmmount = int.Parse(Console.ReadLine());
            int[] array = new int[userAmmount];
            Console.Write("Write numbers separated by (,)or(space): ");
            array = Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.Write("How many elements would you like to use?: ");
            int userElements = int.Parse(Console.ReadLine());

            //This orders the array so the numbers start from highest to lowest and sums them
            int result = array.OrderByDescending(x => x).Take(userElements).Sum();
            int[] resultArray = new int[userElements];
            resultArray = array.OrderByDescending(x => x).Take(userElements).ToArray();

            //This prints the result to the console
            Console.WriteLine("\nThe sum of the elements is: " + result + "\n");
            Console.Write("And the elements are: ");
            foreach (var element in resultArray)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}

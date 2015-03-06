using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
namespace Problem_06.Sum_integers
{
    class SumOfInts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program sums int numbers");
            Console.Write("Write some numbers separated by (space): ");
            string userNumbers = Console.ReadLine();
            int[] numbersArray = userNumbers.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int result = 0;
            foreach (var number in numbersArray)
            {
                result += number;
            }
            Console.WriteLine("The sum of the numbers is: {0}", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
namespace Problem_11.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { };
            Console.WriteLine("This program tryes to finds a number you select in a numbers array");

            //This part fills the array with with the user numbers
            Console.Write("Enter some numbers using(,)or(space) between them: ");
            array = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            array = array.OrderByDescending(x => x).ToArray();//This sorts the user array
            Console.Write("Enter the number you wish to find: ");
            int userNumber = int.Parse(Console.ReadLine());

            //This part finds the user number in the array
            int indexMax = array.Length - 1;
            int indexMin = 0;
            int indexMiddle = (indexMax-indexMin)/2;
            while (indexMin <= indexMax)
            {
                indexMiddle = (indexMin) + (indexMax - indexMin) / 2;
                if (userNumber > array[indexMiddle])
                {
                    indexMax = indexMiddle - 1;
                }
                else if (userNumber < array[indexMiddle])
                {
                    indexMin = indexMiddle + 1;
                }
                if(userNumber == array[indexMiddle])
                {
                    break;
                }
            }

            //This will print the sorted user array in the console
            int j = 0;
            Console.WriteLine("\nYour array was sorted using top secret array sorting technology");
            foreach (var number in array)
            {
                Console.Write("[{0}]={1}\n", j, number);
                j++;
            }
            //This is the final result
            Console.WriteLine("\n\nThe number: {0} is located at index {1}", array[indexMiddle], indexMiddle);
        }
    }
}

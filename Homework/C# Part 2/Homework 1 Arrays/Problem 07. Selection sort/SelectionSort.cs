using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
namespace Problem_07.Selection_sort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { };
            Console.WriteLine("This program sorts numbers in an array...the hard way");

            //This part takes the user input
            Console.Write("Please fill the array with numbers using(,)or(space) between each: ");
            array = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int[] resultArray = new int[array.Length]; 

            //This for loop runs for the ammount of numbers
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = Array.IndexOf(array, array.Min());//This finds the index from the array with the lowest value
                resultArray[i] = array[minIndex];//This puts the lowest value in a new array
                array[minIndex] = Int32.MaxValue;//This sets that lowest value in the original array to a high number(so it doesn't get used again)
            }

            //This part prints the result in the console
            Console.Write("\nYour array sorted in increasing order: ");
            foreach (var result in resultArray)
            {
                Console.Write("{0} ",result);
            }
            Console.WriteLine();
        }
    }
}

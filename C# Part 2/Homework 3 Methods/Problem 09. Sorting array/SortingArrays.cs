using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
namespace Problem_09.Sorting_array
{
    class SortingArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program does many things...mostly boring");
            int[] userArray = new int[] { };
            int[] resultArray = new int[] { };

            //This part fills the array and set's a vlaue for the number we're looking for
            Console.Write("Please fill the array with int numbers using (space) between each: ");
            userArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("At what index of the array do you wish to start looking");
            int index = int.Parse(Console.ReadLine());
            int greatestNum = FindLargestInt(userArray, index);
            Console.WriteLine("Largest number is: " + greatestNum);

            //This part lets the user choose the way the array is sorted and it prints the array
            Console.WriteLine("Now , how may I sort your array sir/madam? ");
            Console.Write("Write (true) for ascending and (false) for decending order(ow and no brackets please): ");
            bool userChoise = bool.Parse(Console.ReadLine().ToLower());
            if (userChoise == true)
            {
                resultArray = SortArray(userArray);
                foreach (var item in resultArray)
                {
                    Console.Write("{0} ", item);
                }
            }
            else if (userChoise == false)
            {
                resultArray = SortArray(userArray, false);
                foreach (var item in resultArray)
                {
                    Console.Write("{0} ", item);
                }
            }
        }
        static int FindLargestInt(int[] array, int index)
        {
            int maxNumber = array[index];// We start with the number at the specifyed index
            for (int i = index; i < array.Length; i++)
            {
                if (maxNumber < array[i])//If there is a greater number we replace it with maxNumber 
                {
                    maxNumber = array[i];
                }
            }
            return maxNumber;
        }
        static int[] SortArray(int[] array, bool choise = true)// If nothing is writen in the bool it sorts by decending by default
        {
            int[] returnArray = new int[array.Length];
            int index = array.Length - 1;
            if (choise == false)
            {
                var result = from element in array // This sorts the array by ascending order(1,2,3...)
                             orderby element ascending
                             select element;
                returnArray = result.ToArray();
                return returnArray;
            }
            else
            {
                var result = from element in array// This sorts the array by descending order(3,2,1...)
                             orderby element descending
                             select element;
                returnArray = result.ToArray();
                return returnArray;
            }
        }
    }
}

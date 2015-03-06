using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
namespace Problem_5.Larger_than_neighbours
{
    class LargerNeighbour
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you create an array and checks if a number is greater then its neighbours");
            int[] userArray = new int[] { };

            //This part fills the array and set's a vlaue for the number we're looking for
            Console.Write("Please fill the array with int numbers using (space) between each: ");
            userArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.Write("\nNow specifly which number you want to look for: ");
            int userNumber = int.Parse(Console.ReadLine());

            //This part calls the method and writes the result in the console
            bool check = Neighbour(userArray, userNumber);
            Console.WriteLine("The number {0} is greater then its neighbours?: {1}", userNumber, check);

        }
        static bool Neighbour(int[] array, int selectedNumber)
        {
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] == selectedNumber)
                {
                    if (i + 1 > array.Length - 1)
                    {
                        return false;
                    }
                    if (array[i] > array[i + 1] && array[i] > array[i - 1]) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise
namespace Problem_06.First_larger_than_neighbours
{
    class FirstLargerThenNeighbour
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
            int check = Neighbour(userArray, userNumber);
            if (check != -1)
            {
                Console.WriteLine("The number {0} is greater then its neighbours", check);
            }
            else
            {
                Console.WriteLine("The number you entered is not greater then its neighbours so I'll return this: {0}\n CUz Im a sutpiD program", check);
            }

        }
        static int Neighbour(int[] array, int selectedNumber)//Only change is from bool to int....
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == selectedNumber)
                {
                    if (i + 1 > array.Length - 1)
                    {
                        return -1;
                    }
                    if (array[i] > array[i + 1] && array[i] > array[i - 1])
                    {
                        return array[i];
                    }
                }
            }
            return -1;
        }
    }
}

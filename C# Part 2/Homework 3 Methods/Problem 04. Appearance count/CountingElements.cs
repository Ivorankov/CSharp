using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
namespace Problem_04.Appearance_count
{
    class CountingElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you create an array and counts how many times a number is in it");
            int[] userArray = new int[] { };

            //This part fills the array and set's a vlaue for the number we're looking for
            Console.Write("Please fill the array with int numbers using (space) between each: ");
            userArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.Write("\nNow specifly which number you want to look for: ");
            int userNumber = int.Parse(Console.ReadLine());

            //This part calls the method and writes the result in the console
            int count = Count(userArray, userNumber);
            Console.WriteLine("The number {0} is contained in the array {1} times", userNumber, count);

        }
        static int Count(int[] array,int selectedNumber)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item == selectedNumber) 
                {
                    count++;
                }
            }
            return count;
        }
    }
}

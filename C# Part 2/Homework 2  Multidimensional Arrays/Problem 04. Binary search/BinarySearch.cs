using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program lets you create an array of int numbers");
            Console.WriteLine("And then you enter a number which it maybe finds in the array...");
            int[] userArray = new int[] { };

            //This part fills the userArray
            Console.WriteLine("Please fill the array with numbers using (space) between each");
            userArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.Write("Now just specify a numbers to search: ");
            int userNumber = int.Parse(Console.ReadLine());


            //This part sorts the array and finds the index of the colsest number to userNumber
            Array.Sort(userArray);
            int numberToFind = 0;
            for (int i = 0; i < userArray.Length; i++)
            {
                if (userNumber <= userArray[i])
                {
                    numberToFind = userArray[i - 1];
                }
 
            }
            var index = Array.BinarySearch(userArray, numberToFind);

            //This part prints the result in the console
            Console.WriteLine("The number {0} is closest to {1} which is located at index {2}",userNumber,userArray[index], index);
        }
    }
}

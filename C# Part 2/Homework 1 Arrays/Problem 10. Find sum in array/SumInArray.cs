using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds in given array of integers a sequence of given sum S (if present).
namespace Problem_10.Find_sum_in_array
{
    class SumInArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { };
            int[] resultArray = new int[]{Int32.MaxValue};//Its initialized with only 1 number containing the max val of an int32(I use it for an if statement below)
            int bufferSum = 0;
            List<int> bufferList = new List<int>();
            Console.WriteLine("This program searches if some of the contents in an array can add up to a given number");

            //This part fills the array from the user input
            Console.Write("Enter some numbers using(,)or(space) between them: ");
            array = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.Write("Enter the resulting sum you wish to check: ");
            int userSum = int.Parse(Console.ReadLine());

            //This for loop runs thru the numbers in the array
            for (int i = 0; i < array.Length; i++)
            {
                //Same logic as in Problem 08.
                if (bufferSum + array[i] <= userSum)
                {
                    bufferSum = bufferSum + array[i];
                    bufferList.Add(array[i]);
                    if (bufferSum == userSum)
                    {
                        resultArray = new int[bufferList.Count];
                        bufferList.CopyTo(resultArray);
                    }
                }
                else
                {
                    bufferList.Clear();
                    bufferSum = 0;
                }
            }

            //This part prints the result in the console
            if (resultArray[0] == Int32.MaxValue)//If no numbers in the array can sum up to the user input the array will remain, resultArray remained unchanged 
            {
                Console.WriteLine("L2 use a calcualtor! No numbers in the array can sum up to {0}", userSum);
            }
            else
            {
                foreach (var result in resultArray)
                {
                    Console.Write("{0} ", result);
                }
            }
        }
    }
}

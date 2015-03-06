using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the sequence of maximal sum in given array.
namespace Problem_08.Maximal_sum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { };
            int[] resultArray = new int[] { };
            int bufferSum = 0;
            int resultSum = 0;
            int previousNumber = 0;
            List<int> bufferList = new List<int>();
            Console.WriteLine("This program finds the maximal sum in an array");

            //This part fills the array from the user input
            Console.Write("Enter some numbers using(,)or(space) between them: ");
            array = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            //This for loop runs thru the numbers in the array
            for (int i = 0; i < array.Length; i++)
            {
                //Same logic as in Problem 05.
                if (previousNumber + array[i] >= 1)
                {
                    previousNumber = array[i];//This is used to compare the number in array index [i-1] to the number at index[i](for the next time the loop starts)
                    bufferSum = bufferSum + array[i];
                    bufferList.Add(array[i]);
                    if (bufferSum >= resultSum)
                    {
                        resultArray = new int[bufferList.Count];
                        resultSum = bufferSum;
                        bufferList.CopyTo(resultArray);
                    }
                }
                else
                {
                    previousNumber = 0;
                    bufferList.Clear();
                    bufferSum = 0;
                }
            }
            Console.Write("\nThis is the max sum sequence: ");
            foreach (var result in resultArray)
            {
                Console.Write("{0} ",result);
            }
            Console.WriteLine();
        }
    }
}

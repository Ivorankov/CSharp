using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
namespace Problem_08.Number_as_array
{
    class NumberArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program creates an array using two numbers");

            //This part takes the user input
            Console.Write("Enter the first number: ");
            string firstNumber = Console.ReadLine();
            int[] firstArray = firstNumber.Select(x => int.Parse(x.ToString())).ToArray();
            Console.Write("Enter the second number: ");
            string secondNumber = Console.ReadLine();
            int[] secondArray = secondNumber.Select(x => int.Parse(x.ToString())).ToArray();

            //This part calls the method and prints the result in the console
            int[] result = CreateArray(firstArray, secondArray);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0}", result[i]);
            }
            Console.WriteLine();
        }
        static int[] CreateArray(int[] firstArray, int[] secondArray)
        {
            int sum = 0;
            int remain = 0;
            int length = firstArray.Length;
  
            int[] resultArray = new int[length];
            //for some reason in the assignment its sayd that the last digit is located at index [0] so both arrays get reversed
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            for (int i = 0; i < firstArray.Length; i++)
            {
                sum = firstArray[i] + secondArray[i];
                sum %= 10;
                resultArray[i] = sum + remain;
                if (firstArray[i] + secondArray[i] >= 10)
                {
                    remain = 1; 
                }
                else
                {
                    remain = 0;
                }
            }
            Array.Reverse(resultArray);//and again we reverse so it comes out the right way 
            return resultArray;
        }
    }
}

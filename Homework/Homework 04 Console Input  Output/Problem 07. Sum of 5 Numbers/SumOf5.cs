using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
namespace Problem_07.Sum_of_5_Numbers
{
    class SumOf5
    {
        static void Main(string[] args)
        {
            string[] numbersArray,testArray;
            testArray = new string[5];
            string numbers;
            double result = 0;

            Console.WriteLine("This program sums 5 numbers");
            here:
            Console.Write("Please enter the 5 numbers using space between each: ");
            numbers = Console.ReadLine();

            numbersArray = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //This will create the array
            if (numbersArray.Length > testArray.Length || numbersArray.Length < testArray.Length)    // This will validate the array lenght
            {
                Console.WriteLine("The numbers u entered are less or more then 5, or you didn't use space between some of the numbers");
                goto here;
            }
            for (int i = 0; i <= 4; i++)                                                             // This will calculate the numbers
            {
                result = result + double.Parse(numbersArray[i]);
            }
            Console.WriteLine("The sum of the 5 numbers is: " + result);                             //This will print the sum of the numbers
        }
    }
}

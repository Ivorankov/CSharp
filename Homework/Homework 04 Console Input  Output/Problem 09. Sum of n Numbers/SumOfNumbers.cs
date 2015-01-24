using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
namespace Problem_09.Sum_of_n_Numbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            string[] numbersArray,testArray;
            string numbers;
            double result = 0;
            int n,i;

            Console.WriteLine("This program sums a chosen ammount of numbers");
            Console.Write("How many numbers would you like to use?: ");

            //This part validates and inputs the user data
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Please use numeric values,and make sure you enter a whole number");
                Console.Write("How many numbers would you like to use?: ");
            }
            testArray = new string[n];
            here:
            Console.Write("Please enter the numbers using space between each: ");
            numbers = Console.ReadLine();

            numbersArray = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);      //This part puts the numbers in an array 
            if (numbersArray.Length > testArray.Length || numbersArray.Length < testArray.Length)         //This will validate the length of the array
            {
                Console.WriteLine("The numbers u entered are less or more then " + n + " , or you didn't use space between some of the numbers");
                goto here;
            }
            for (i = 0; i <= n-1; i++)
            {
                result = result + double.Parse(numbersArray[i]);
            }

            //This part displays the outcome 
            Console.WriteLine(result);                                                                  
        }
    }
}

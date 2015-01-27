using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space
namespace Problem_1.Numbers_from_1_to_N
{
    class NumberPrinter
    {
        static void Main(string[] args)
        {
            int userNumber, i;
            string formatedNumbers;
            List<int> list = new List<int>();//Using a list makes it that much easyer
            Console.WriteLine("Welcome to number printer 2.0");
            Console.WriteLine("This program prints the numbers from 1 to your chosen number");
            Console.Write("Please enter a possitive number: ");

            //This will validate the user input
            while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 0)
            {
                Console.Write("Please use numeric values, possitve numbers only: ");
            }

            //This for loop starts creating the numbers needed
            for (i = 1; i <= userNumber; i++)
            {
                list.Add(i);//This adds every number to the list
            }

            formatedNumbers = string.Join(" ", list.ToArray());//This formats the items in the list 
            Console.WriteLine(formatedNumbers);//This prints the formated numbers to the console
        }
    }
}

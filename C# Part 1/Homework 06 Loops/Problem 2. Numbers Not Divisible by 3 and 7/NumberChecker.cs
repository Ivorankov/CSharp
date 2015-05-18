using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
namespace Problem_2.Numbers_Not_Divisible_by_3_and_7
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            int userNumber, i;
            string formatedNumbers;
            List<int> list = new List<int>();//Using a list makes it that much easyer
            Console.WriteLine("Welcome to number printer 3.0");
            Console.WriteLine("This program prints the numbers from 1 to your chosen number, but it forgets numbers sometimes...");
            Console.Write("Please enter a possitive number: ");

            //This will validate the user input
            while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 0)
            {
                Console.Write("Please use numeric values, possitve numbers only: ");
            }

            //This for loop starts running thru the numbers from 1 to n
            for (i = 1; i <= userNumber; i++)
            {
                //This if checks if a number is not devisible by 3 and 7 
                if (i % 3 != 0 && i % 7 != 0)
                {
                    list.Add(i);//This adds the numbers we want in the list
                }
            }

            formatedNumbers = string.Join(" ", list.ToArray());//This formats the items in the list
            Console.WriteLine(formatedNumbers);//This prints the formated numbers to the console
            Console.WriteLine("HA ITS LIKE THE PREVIOUS ONE BUT WITH BAD MEMORY!");
        }
    }
}

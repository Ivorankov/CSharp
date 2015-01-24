using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
namespace Problem_11.Numbers_in_Interval_DividablebyN
{
    class NumberIntervalCheck
    {
        static void Main(string[] args)
        {
            int begin, end,amount, i;
            List<int> listNumbers = new List<int>();
            string numbers;

            Console.WriteLine("This program will do something...not sure what but...");
            Console.WriteLine();
            Console.WriteLine("Ok Ok you choose two positive numbers and then the program will tell you which numbers in  between will be devided by 5 will = 0");
            Console.WriteLine();
            Console.Write("Please enter the starting number: ");

            //This part will validate the user input.
            while(!int.TryParse(Console.ReadLine(), out begin))                          
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Write("Please enter the ending number: ");
            while(!int.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("Please use numeric values");
            }
            amount = 0;

            //This will start a loop from the starting to the ending number
            for (i = begin;i <= end;i++)                                                 
            {
                if(i % 5 == 0) //If any of the numbers devided by 5 = 0, it will add them to a list
                {
                    listNumbers.Add(i);
                    amount++;
                }
            }
            Console.WriteLine();
            numbers = string.Join(", ", listNumbers.ToArray()); //This will put the numbers in the list in a string 
            Console.WriteLine("The numbers are: " + numbers+amount);//This will print the numbers to the console
        }
    }
}

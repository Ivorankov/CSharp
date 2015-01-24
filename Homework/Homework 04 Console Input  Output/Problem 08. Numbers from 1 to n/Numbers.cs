using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
namespace Problem_08.Numbers_from_1_to_n
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int number,i;

            Console.WriteLine("This program will print the numbers from 1 to the number you chose");
            Console.Write("Choose the number!: ");

            //This part will validate the user input
            while (!int.TryParse(Console.ReadLine(), out number))                                    
            {
                Console.WriteLine("Pease use numeric values,and make sure the number is an int");
            }

            //I use if-else so that the program can print negative numbers
            if (number > 0)                                                                          
            {
                for (i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (i = 1; i >= number; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

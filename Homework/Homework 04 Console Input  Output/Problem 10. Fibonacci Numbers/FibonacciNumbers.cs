using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233,...
namespace Problem_10.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            List<int> fibonacciSequence= new List<int>();
            int i,a,b,fibNumber,amount;
            string numbers;

            Console.WriteLine("This program will display numbers from the fibonacci sequence");
            Console.Write("Choose the ammount of numbers you wish to see: ");
            while (!int.TryParse(Console.ReadLine(), out amount))                             //This part will validate the user input
            {
                Console.WriteLine("Please use numeric values");                  
            }
            a = 0;
            b = 1;
            for (i = 0; i < amount;i++)                                                      //This will run the sequence for the amount of times the user wants
            {
                fibNumber = a;
                a = b;
                b = fibNumber + b;
                fibonacciSequence.Add(fibNumber);                                           //This will add the fibonacci numbers in a list
            }
            foreach (int fibb in fibonacciSequence)
            {

            }
            numbers = string.Join(", ", fibonacciSequence.ToArray());                      //This will format the list content so that we get the numbers in 1 line
            Console.WriteLine(numbers);                                                    //And Voala we print it to console
        }
    }
}

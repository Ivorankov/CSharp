using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
//As a result print the values a and b, separated by a space.
namespace Problem_1.Exchange_If_Greater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double first, last, temp;

            Console.WriteLine("This program will compare 2 numbers and pull a ruse!");
            Console.Write("Please enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out first))  //This part validates the user input
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Please enter the first number: ");
            }
            Console.Write("Please enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out last))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Please enter the second number: ");
            }

            if (first > last)      // This part will switch the values if the first  > last
            {
                temp = first;
                first = last;
                last = temp;
            }
            Console.WriteLine("first=" + first + " " + "last=" + last); //This part will print the result to console
        }
    }
}

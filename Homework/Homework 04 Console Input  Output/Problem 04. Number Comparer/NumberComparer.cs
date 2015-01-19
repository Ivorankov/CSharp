using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
namespace Problem_04.Number_Comparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            int x, y, n;

            Console.WriteLine("This smart program can tell which number is bigger!!!");
            Console.Write("Write a number: ");
            while (!int.TryParse(Console.ReadLine(), out x))                            //This part validates the user input
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Write("Write another number: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Please use numeric values");
            }
            n = Math.Max(x, y);                                                       //This part finds the greater number
            Console.WriteLine("----- " + n + " IS BIGGER WOOOOO" + " -----");         //This part prints the result to the console
        }
    }
}

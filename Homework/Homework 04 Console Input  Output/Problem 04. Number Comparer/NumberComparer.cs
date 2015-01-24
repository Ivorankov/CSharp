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

            //This part validates the user input
            while (!int.TryParse(Console.ReadLine(), out x))                            
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Write("Write another number: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Please use numeric values");
            }

            //This part finds the greater number and prints the result to the console
            n = Math.Max(x, y);                                                       
            Console.WriteLine("----- " + n + " IS BIGGER WOOOOO" + " -----");         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write an expression that checks if given integer is odd or even.
namespace Problem_1.Odd_or_Even_Integers
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the odd or even game");
            Console.Write("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0) 
            {
                Console.WriteLine(n + " is even");
            }
            else 
            {
                Console.WriteLine(n + " is odd");
            }
        }
    }
}

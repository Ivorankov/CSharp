using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
namespace Problem_8.Prime_Number_Check
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int number, n;

            Console.WriteLine("Welcome to prime checker, Optimus Prime's favorite progam");
            Console.Write("Enter a possitive number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 1 || number == 2) 
            {
                Console.WriteLine("The number is prime");
            }

            for (n = 2; n < number; n++)
            {
                if (number % n == 0)
                {
                    Console.WriteLine("The number isn't prime");
                    break;
                }
                else
                {
                    Console.WriteLine("The number is prime");
                    break;
                }
            }
        }
    }
}

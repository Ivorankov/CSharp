using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm
namespace Problem_15.Prime_numbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            //This part creates and fills a list with bool values
            List<bool> numbers = new List<bool>();
            for (int k = 0; k < 10000000; k++)
            {
                numbers.Add(true);//Initially set to true
            }
            //These 2 for loops run thru the list
            for (int i = 2; i < Math.Sqrt(numbers.Count); i++)
            {
                if (numbers[i] == true)//We skip indexes already set to false
                {
                    for (int j = i * i; j < numbers.Count - 1; j += i)
                    {
                        numbers[j] = false;
                    }
                }
            }
            Console.WriteLine("This is how it works for 30 numbers");
            for (int x = 1; x < 30; x++)
            {
                if (numbers[x] == true)
                {
                    Console.Write("{0} ", x);
                }
            }
            Console.WriteLine("\nDo you want to see what happest with 10 000 000 numbers?(yes/no)");
            string userChoise = Console.ReadLine().ToUpper();
            if (userChoise == "NO" || userChoise == "N")
            {
                return;
            }
            else if (userChoise == "YES" || userChoise == "Y")
            {
                //This part spams the console with a gillion billion numbers...Looks nasty if you ask me
                for (int x = 2; x < numbers.Count; x++)
                {
                    if (numbers[x] == true)
                    {
                        Console.Write("{0} ", x);
                    }
                }
            }
        }
    }
}

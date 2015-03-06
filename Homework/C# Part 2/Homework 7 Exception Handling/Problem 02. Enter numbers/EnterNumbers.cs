using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
namespace Problem_02.Enter_numbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 10 numbers within the range 2-99: ");

                for (int i = 0; i < 10; i++)
                {
                    string userNumber = Console.ReadLine();
                    int number = ReadNumber(userNumber);
                }
            
        }
        static int ReadNumber(string userNumber)
        {
            int number = -1;
            try
            {
            number = int.Parse(userNumber);
            if (number < 2 || number > 99)
            {
                throw new ArgumentOutOfRangeException();
            }

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number not in range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Number was not in the correct format");
            }
            return number;
        }
    }
}

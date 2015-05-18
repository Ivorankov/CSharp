using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
namespace Problem_13.Solve_tasks
{
    class MuliTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program does math stuff");
            Console.WriteLine("1 - Reverse the number\n" + "2 - Find the average of some numbers\n" + "3 - Solve linear equation");

            //This part lets the user choose the methond
            Console.Write("Please select what you wish to do(write 1 2 or 3): ");
            int userChoise = int.Parse(Console.ReadLine());

            switch (userChoise)
            {
                case 1: ReverseNumber(); break;
                case 2: Average(); break;
                case 3: LenearEquation(); break;
                default: Console.WriteLine("Invalid input"); break;
                    
            }
        }
        static void ReverseNumber()
        {
            Console.Clear();
            Console.WriteLine("Number reverser");
            Console.WriteLine("Write a possitive number");
            decimal num = 0;
            //This validates the user input (must be a possitve number)
            do
            {
                num = decimal.Parse(Console.ReadLine());
            } while (num < 0);

            char[] array = num.ToString().ToCharArray();

            array = array.Reverse().ToArray();
            Console.WriteLine("This is your number in reverse");
            foreach (var digit in array)
            {
                Console.Write("{0}", digit);
            }
            Console.WriteLine();
        }
        static void Average()
        {
            Console.Clear();
            Console.WriteLine("Average of numbers");
            int[] array = new int[] { };
            Console.WriteLine("Write at least two int numbers using (space) between each");
            //This validates the user input (needs at least 2 numbers)
            do
            {
                array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            } while (array.Length < 2);

            decimal average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];

            }
            average /= array.Length;
            Console.WriteLine("The average of the numbers is: " + average);
        }
        static void LenearEquation()
        {
            Console.Clear();
            Console.WriteLine("Linear equation calc");
            Console.Write("Write the first component(ex. 2x, 5a, 8y),note that it canno't be equal to 0: ");
            string firstNumber = string.Empty;
            //This validates the user input (first component canno't be 0)
            do
            {
                string first = Console.ReadLine();
                firstNumber = new String(first.TakeWhile(Char.IsDigit).ToArray());//Takes the number in front of x(or whatever char the user wrote)

            } while (firstNumber == "0");

            Console.Write("Write the second component(ex. 5,6,7,11..): ");
            decimal second = decimal.Parse(Console.ReadLine());
            decimal number = decimal.Parse(firstNumber);

            decimal result = second / number;
            Console.WriteLine("The result is: {0}",result);
        }
    }
}

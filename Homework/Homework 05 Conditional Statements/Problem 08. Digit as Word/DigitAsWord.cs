using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.
namespace Problem_08.Digit_as_Word
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("This program will tell you how to spell numbers correctly");
            Console.Write("Enter the number you desire(between 1 and 9..): ");
            //This part will validate the user input
            while (!int.TryParse(Console.ReadLine(), out number) || (number < 1 || number > 9))
            {
                Console.WriteLine("Please use numeric values between 1-9!");
                Console.Write("Enter the number you desire(between 1 and 9..): ");
            }
            //This part will run the user's input thru the cases and print the result to the console
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the last digit of given integer as an English word.
namespace Problem_03.English_digit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program steals a digits from a number you wirte!");
            Console.Write("Please enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            DigitToWord(userNumber);
            Console.WriteLine();
        }
        static void DigitToWord(int input)
        {
            int digit = input % 10;
            Console.Write("The last digit from your number as a word is: ");
            switch (digit)
            {
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eight"); break;
                case 9: Console.Write("Nine"); break;
                case 0: Console.Write("Zero"); break;
            }  

        }
    }
}

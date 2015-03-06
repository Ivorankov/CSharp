using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
namespace Problem_01.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to leap year checker 2.0");
            Console.Write("Write a year: ");
            int userYear = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(userYear))
            {
                Console.WriteLine("WOHOO IT'S LEAP YEAR!");
            }
            else
            {
                Console.WriteLine("It's not leap year :(, better luck next year");
            }
        }
    }
}

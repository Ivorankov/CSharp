using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.
namespace Problem_03.Day_of_week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program tells you the day of the week"); ;
            DateTime day = new DateTime();
            Console.WriteLine("It's " + day.DayOfWeek);
        }
    }
}

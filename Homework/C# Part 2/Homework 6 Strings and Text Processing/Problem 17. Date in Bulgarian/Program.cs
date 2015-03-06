using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
namespace Problem_17.Date_in_Bulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo test = new CultureInfo("bg-Bg");
            DateTime date = new DateTime();
            Console.WriteLine("This program adds hours to dates");
            Console.Write("Write the date in format(DD.MM.YYYY HH:MM:SS ");
            date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy HH:mm:ss", test);
            date = date.AddHours(6);
            date = date.AddMinutes(30);

            Console.WriteLine(date +" "+ date.DayOfWeek);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them
namespace Problem_16.Date_difference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime();
            DateTime end = new DateTime();

            Console.WriteLine("This program calculates day spans");
            Console.Write("Write start date(D.M.YYYY) ");
            start = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Write end date(D.M.YYYY) ");
            end = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("There are {0} days between the dates", (end - start).TotalDays);
        }
    }
}

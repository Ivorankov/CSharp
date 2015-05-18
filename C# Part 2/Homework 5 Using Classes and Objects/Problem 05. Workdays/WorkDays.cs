using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
namespace Problem_05.Workdays
{
    class WorkDays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates work days");

            //This lets the user choose the end date
            Console.Write("Please specify the end date(in the format YYYY MM DD): ");
            string userInput = Console.ReadLine();
            DateTime endDate = DateTime.Parse(userInput);

            //This part calls the method and prints the result
            int result = WorkDaysAmount(todayDate, endDate);
            Console.WriteLine("The total amount of work days is: {0}", result);

        }
        static DateTime[] holidays = {
                                       new DateTime(2015, 01, 01), new DateTime(2015, 03, 03), new DateTime(2015, 05, 24),//This array holds the holydays
                                       new DateTime(2015, 09, 06),new DateTime(2015, 09, 22), new DateTime(2015, 10, 01)
                                     };
        static DateTime todayDate = DateTime.Today;//This gets the current date
        static int WorkDaysAmount(DateTime startDate, DateTime endDate)
        {
            int amountOfDays = 0;
            DateTime tempDate = startDate;
            while (startDate <= endDate)
            {
                if (holidays.Contains(tempDate))
                {
                    startDate = startDate.AddDays(1);
                    continue;
                }
                startDate = startDate.AddDays(1);//we add one day each time
                amountOfDays++;
            }
            return amountOfDays;
        }
    }
}

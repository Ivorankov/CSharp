using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time 
//or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and time
namespace Problem_10.Beer_Time
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Parse("01:00 PM");
            DateTime end = DateTime.Parse("03:00 AM");
            DateTime time;

            Console.WriteLine("In this program you enter a time and it tells you if its time for beer :D");
            Console.Write("Enter the time in the format hh:mm tt: ");
            //This part will validate the user input
            while (!DateTime.TryParse(Console.ReadLine().ToUpper(), out time))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Make sure you follow the format(ex. 12:00 AM): ");
            }
            //This part will check if you can have a beer
            if (time >= start)
            {
                Console.WriteLine("Beer time!");
            }
            else if (time <= end)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("No beer!" + " Happy hour is between 01:00 PM and 03:00 AM");
            }
        }
    }
}

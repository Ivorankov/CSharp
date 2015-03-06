using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
namespace Age_after_10_years
{
    class AgeCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,");
            Console.WriteLine("Please enter your year of birth:");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the month you were born in: using the following format - 1,2,3...");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All that's left is the day you were born: using the following format - 1,2,3...");
            int Day = Convert.ToInt32(Console.ReadLine());
            int Age;
            if (DateTime.Today.Year > Year&&DateTime.Today.Month < Month)
            {
                Age = DateTime.Today.Year - Year -1;
                Console.WriteLine("You are "+Age+" years old and you will be "+(Age+10)+" in 10 years");
            }
            else if (DateTime.Today.Year > Year&&DateTime.Today.Month > Month)
            {
                Age = DateTime.Today.Year - Year;
                Console.WriteLine("You are " + Age + " years old and you will be " + (Age + 10) + " in 10 years");
            }
            else if (DateTime.Today.Year > Year&&DateTime.Today.Month == Month&&DateTime.Today.Day>Day)
            {
                Age = DateTime.Today.Year - Year;
                Console.WriteLine("You are " + Age + " years old and you will be " + (Age + 10) + " in 10 years");
            }
            else if (DateTime.Today.Year > Year && DateTime.Today.Month == Month && DateTime.Today.Day < Day)
            {
                Age = DateTime.Today.Year - Year - 1;
                Console.WriteLine("You are " + Age + " years old and you will be " + (Age + 10) + " in 10 years");
            }
            else if (DateTime.Today.Month == Month && DateTime.Today.Day == Day)
            {
                Age = DateTime.Today.Year - Year;
                Console.WriteLine("HAPPY BIRTHDAY! you are " + Age + " years old and you will be " + (Age + 10) + " in 10 years");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

namespace Problem_3.Divide_by_7_and_5
{
    class DividerofNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi this program helps you figure out if a number can be devided by 7 & 5");
            Console.Write("Enter the number you're thinking about: ");

            int number = Convert.ToInt32(Console.ReadLine());
            bool test = true;
            test = (number % 5 == 0 && number % 7 ==0);

            if (test)
            {
                Console.WriteLine("The number can be devided by 7 and 5");
            }
            else
            {
                Console.WriteLine("The number cannot be devided by both 7 and 5");
            }
        }
    }
}

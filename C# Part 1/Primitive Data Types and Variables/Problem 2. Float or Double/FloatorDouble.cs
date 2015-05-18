using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.
namespace Problem_2.Float_or_Double
{
    class FloatorDouble
    {
        static void Main(string[] args)
        {
            float a = 12.345F;
            float b = 3456.091F;
            double c = 8923.1234857;
            double d = 34.567839023;

            Console.WriteLine(a + " " + b + " " + c + " " + d);
        }
    }
}

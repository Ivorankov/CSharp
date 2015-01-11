using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
namespace Problem_13.Comparing_Floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double x, y,eps;
            bool tester;
            Console.WriteLine("Hello, welcome to the obvious progam");
            Console.WriteLine("You enter 2 digits and if they are equal the progam says theyr equal and vise versa ...yey");
            Console.WriteLine("Please enter a numeric valiue for x");
            do
            {
                tester = Double.TryParse(Console.ReadLine(), out x);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false);
            Console.WriteLine("Please enter a numeric valiue for y");
            do
            {
                tester = Double.TryParse(Console.ReadLine(), out y);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false);
           
            eps = Math.Abs(x * .000001);
            if (Math.Abs(x - y) < eps)
                Console.WriteLine("The two nubers are equal");
            else
                Console.WriteLine("The two numbers are not equal");
        }
    }
}

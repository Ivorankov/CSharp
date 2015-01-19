using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
namespace Problem_6.Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            
            Console.WriteLine("This program solves quadratic equations");
            Console.Write("Enter a number for a: ");
            while (!double.TryParse(Console.ReadLine(), out a))                     //This part validates the user input
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Enter a number for a: ");
            }
            Console.Write("Enter a number for b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Enter a number for b: ");
            }
            Console.Write("Enter a number for c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Please use numeric values!");
                Console.Write("Enter a number for c: ");
            }
            x = (-b + Math.Sqrt(b*b- 4 * a * c)) / (2*a);                         //This part works the magic of Math. and prints the results
            Console.WriteLine("X1=: " + x);
            x = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2*a);
            Console.WriteLine("X2=: " + x);
        }
    }
}

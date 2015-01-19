using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
namespace Problem_3.Circle_Perimeter_and_Area
{
    class PerimeterNArea
    {
        static void Main(string[] args)
        {
            double radius, perimeter, area;

            Console.WriteLine("This program will calculate the perimeter and area of a circle");
            Console.Write("Enter the radius of the circle: ");
            while (!double.TryParse(Console.ReadLine(), out radius))                                                        //This part validates the user input 
            {
                Console.WriteLine("Please use numeric values");
            }
            perimeter = Math.PI * radius * 2;                                                                               //This part calculates the perimeter and area
            area = Math.PI * radius * radius;

            Console.WriteLine();
            Console.WriteLine("The area of the circle is: " + Math.Round(area,2,MidpointRounding.AwayFromZero));            //This part prits the result to console
            Console.WriteLine("The perimeter of the circle is: " + Math.Round(perimeter, 2, MidpointRounding.AwayFromZero));
        }
    }
}

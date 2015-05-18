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

            //This part validates the user input 
            while (!double.TryParse(Console.ReadLine(), out radius))                                                        
            {
                Console.WriteLine("Please use numeric values");
            }

            //This part calculates the perimeter and area
            perimeter = Math.PI * radius * 2;                                                                               
            area = Math.PI * radius * radius;
            Console.WriteLine();

            //This part prits the result to console
            Console.WriteLine("The area of the circle is: " + Math.Round(area,2,MidpointRounding.AwayFromZero));            
            Console.WriteLine("The perimeter of the circle is: " + Math.Round(perimeter, 2, MidpointRounding.AwayFromZero));
        }
    }
}

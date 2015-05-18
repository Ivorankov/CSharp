using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//    Side and an altitude to it;
//    Three sides;
//    Two sides and an angle between them;
//Use System.Math.
namespace Problem_04.Triangle_surface
{
    class TriangleCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This prgram calculates triangle surfaces");
            Console.WriteLine("Please choose one of the menu options");
            Console.WriteLine("1 - You'll have to input a side and the altitute to it");
            Console.WriteLine("2 - You'll have to input 3 sides of the triangle");
            Console.WriteLine("3 - You'll have to input 2 sides and the angle between them");
            int userChoise = int.Parse(Console.ReadLine());
            switch (userChoise)
            {
                case 1:
                    Console.Write("Write a side of the triangle: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.Write("Write the altitute to it: ");
                    double altitute = double.Parse(Console.ReadLine());
                    SurfaceWithAltitute(side, altitute);
                    break;
                case 2:
                    Console.Write("Write the x side of the triangle: ");
                    double sideX = double.Parse(Console.ReadLine());
                    Console.Write("Write the y side of the triangle: ");
                    double sideY = double.Parse(Console.ReadLine());
                    Console.Write("Write the z side of the triangle: ");
                    double sideZ = double.Parse(Console.ReadLine());
                    SurfaceWith3Sides(sideX, sideY, sideZ);
                    break;
                case 3:
                    Console.Write("Write the x side of the triangle: ");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.Write("Write the y side of the triangle: ");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.Write("Write the angle between the sides: ");
                    double angle = double.Parse(Console.ReadLine());
                    SurfaceWithAngle(side1, side2, angle);
                    break;

                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            
        }
        static void SurfaceWithAltitute(double x, double h)
        {
            double result = (x * h) / 2;
            Console.WriteLine("The surface is: {0}",result);
        }
        static void SurfaceWith3Sides(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double result = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            Console.WriteLine("The surface is {0}",result);
        }
        static void SurfaceWithAngle(double a, double b, double angle)
        {
            double result = (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
            Console.WriteLine("The surface is: {0}", result);
        }
    }
}

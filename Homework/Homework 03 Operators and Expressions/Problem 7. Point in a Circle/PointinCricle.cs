using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write an expression that checks if given point (x, y) is inside a given circle.
namespace Problem_7.Point_in_a_Circle
{
    class PointinCricle
    {
        static void Main(string[] args)
        {
            double x,y,centerX,centerY,radius,distanceTopoint,left;

            Console.Write("Enter your x coordinates: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your y coordinates: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the cricles x coordinates: ");
            centerX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the circles y coordinates: ");
            centerY = Convert.ToDouble(Console.ReadLine());

            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            centerX = Math.Pow(centerX, 2);
            centerY = Math.Pow(centerY, 2);

            distanceTopoint = Math.Sqrt(x + y);
            radius = Math.Sqrt(centerX + centerY);

            if (radius>=distanceTopoint)
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                left = distanceTopoint - radius;
                Console.WriteLine("The point isnt in the circle");
                Console.WriteLine("You have "+left+" Miles to Graceland :D (till you reach the circle)");
            }
        }
    }
}

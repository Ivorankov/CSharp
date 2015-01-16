using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle(
//R(top(I asume right) =1, (top?)left=-1, width=6, height=2).
namespace Problem_10.Point_Inside_a_CrcandRect
{
    class PointinCandR
    {
        static void Main(string[] args)
        {
            double x, y, centerX, centerY, radius, distanceTopoint,tLeftRect,tRightRect,bLeftRect,bRightRect;
            radius = 1.5;
            centerX = 1;
            centerY = 1;
            tLeftRect = -1;
            tRightRect = 1;
            bLeftRect = -5;
            bRightRect = -5;
            Console.Write("Enter your x coordinates: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your y coordinates: ");
            y = Convert.ToDouble(Console.ReadLine());

            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            centerX = Math.Pow(centerX, 2);
            centerY = Math.Pow(centerY, 2);

            distanceTopoint = Math.Sqrt(x + y);
            radius = Math.Sqrt(centerX + centerY);

            if (radius >= distanceTopoint)
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                Console.WriteLine("The point isnt in the circle");
            }

            if(x > tRightRect | x < tLeftRect | y < bLeftRect | y <= 0)
            {
                Console.WriteLine("The point is not in the rectangle");
            }
            else
            {
                Console.WriteLine("The point is in the rectangle");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double upBase, downBase, height,area;
            Console.WriteLine("This progarm calculates area's of trapezoids(whatever that is)");
            Console.Write("Enter the top base: ");
            upBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the bottom base: ");
            downBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height: ");
            height = Convert.ToInt32(Console.ReadLine());

            area = (((upBase + downBase) / 2) * height);
            Console.WriteLine("The area of the trapezoid is: "+ area);
        }
    }
}

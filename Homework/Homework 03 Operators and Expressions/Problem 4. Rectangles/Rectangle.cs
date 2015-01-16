using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
namespace Problem_4.Rectangles
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            int height,width,perimeter,area;
            Console.WriteLine("This program calcucates rectangles!!!");
            Console.Write("Enter the height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = Convert.ToInt32(Console.ReadLine());

            perimeter = (height + width) * 2;
            area = height * width;

            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}

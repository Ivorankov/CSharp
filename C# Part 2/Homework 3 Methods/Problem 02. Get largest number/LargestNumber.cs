using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Get_largest_number
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the largest of 3 numbers");
            Console.Write("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int third = int.Parse(Console.ReadLine());

            int firstPair = GetMax(first, second);
            int finalResult = GetMax(firstPair, third);

            Console.WriteLine("The largest number is: " + finalResult);

        }
        static int GetMax(int x, int y) 
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
namespace Problem_12.Null_Values_Arithmetic
{
    class NullArithmetic
    {
        static void Main(string[] args)
        {
            int? a;
            double? b;
            Console.WriteLine("This is what null valiues look like");
            a = null;
            b = null;
            Console.WriteLine(a+" "+b);
            Console.WriteLine("And this is what happens when I add a number to them");
            a = 5;
            b = 10;
            Console.WriteLine("a = "+a+" b = "+b);
        }
    }
}

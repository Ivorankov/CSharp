using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
namespace Problem_1.Declare_Variables
{
    class Declare
    {
        static void Main(string[] args)
        {
            sbyte b = -115;
            sbyte a = 97;
            short c = 10000;
            ushort d = 52130;
            int e = 4825930;

            Console.WriteLine(a+" "+b+" "+c+" "+d+" "+e);
        }
    }
}

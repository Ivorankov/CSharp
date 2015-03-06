using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_08.Binary_short
{
    class BinaryRepresent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows you the 1's and 0's of a small number");
            Console.Write("Write some small number: ");
            short userInput = short.Parse(Console.ReadLine());

            string result = Convert.ToString(userInput,2).PadLeft(16, '0');//Formats the number to binary
            Console.WriteLine("And the result is: " + result);
        }
    }
}

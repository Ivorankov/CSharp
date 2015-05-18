using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Problem_14.Print_the_ASCII_Table
{
    class ASCIITable
    {
        static void Main(string[] args)
        {
            for (char c = (char)0; c <= (char)255; ++c)
            {
                Console.WriteLine(c);
            }
        }
    }
}

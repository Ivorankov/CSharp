using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a number and prints it as a decimal number,
//hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols
namespace Problem_11.Format_number
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will make numbers look funny");
            Console.Write("Write the number: ");
            string userNumber = Console.ReadLine();

            Console.WriteLine("{0,15:D}", int.Parse(userNumber));//As decimal
            Console.WriteLine("{0,15:X}", int.Parse(userNumber));//As hex
            Console.WriteLine("{0,15:P}", double.Parse(userNumber) / 100);//As Percent
            Console.WriteLine("{0,15:C}", decimal.Parse(userNumber));//As currency
            Console.WriteLine("{0,15:E}", decimal.Parse(userNumber));//As scientific notation
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
namespace Problem_05.Formatting_Numbers
{
    class FormatNumbers
    {
        static void Main(string[] args)
        {
            int number;
            double number2, number3;
            string binary,firstNumber,secondNumber,thirdNumber,result;

            Console.WriteLine("This program makes no sence");      //This part takes the input from the user and validates it.
            here:
            Console.Write("Enter a positive number from 0 to 500: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please use numeric values");
            }
            if (number > 500 || number < 0)
            {
                Console.WriteLine("The number should be between 0 and 500");
                goto here; // This is my new favourite thing :D 
            }
            Console.Write("Enter a floating point number, whatever that is: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Write("Enter another floating point number, whatever that is: ");
            while (!double.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine("Please use numeric values");
            }
            firstNumber = "a";                                  //This is used for the top of the table
            secondNumber = "b";
            thirdNumber = "c";
            result = "Result";
            binary = Convert.ToString(number, 2).PadLeft(16,'0');  
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,20}",firstNumber,secondNumber,thirdNumber,result);    //This part prints the results to the console
            Console.WriteLine("{0,-10}{1,-10}{2,-10}|{0,10:X}|{3,10}|{1,10:0.00}|{2,-10:0.000}|",number,number2,number3,binary);

            
        }
    }
}

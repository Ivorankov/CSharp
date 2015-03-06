using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
namespace Problem_01.Say_Hello
{
    class HelloAgain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program says hello");
            Console.Write("Write your name: ");
            string userInput = Console.ReadLine();
            Hello(userInput);
        }
        static void Hello(string userInput) 
        {
            Console.WriteLine("Hello " + userInput);
        }
    }
}

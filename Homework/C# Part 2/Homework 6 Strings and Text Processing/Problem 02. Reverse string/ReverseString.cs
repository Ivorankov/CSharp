using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string, reverses it and prints the result at the console.
namespace Problem_02.Reverse_string
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reverses strings");

            //This part takes the user input
            Console.Write("Write some text: ");
            string userInput = Console.ReadLine();

            //This part reverses the input
            StringBuilder result = new StringBuilder();
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                result.Append(userInput[i]);
            }

            //This prints the result in the console
            Console.WriteLine("Here is the reversed string: " + result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check if in a given expression the brackets are put correctly.
namespace Problem_03.Correct_brackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program validates brackets");
            Console.Write("Write an expression: ");
            string userInput = Console.ReadLine();
            int openBracket = 0;
            int closeBracket = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == '(')
                {
                    openBracket++;
                }
                else if (userInput[i] == ')')
                {
                    closeBracket--;
                }
                if (openBracket + closeBracket < 0)// if we first encounter ')' then its invalid ( the closeBrackets becomes -1)
                {
                    Console.WriteLine("Invalid use of brackets");
                    break;
                }
            }
            if (openBracket + closeBracket == 0)//If there are equal amount of closing and opening brackets its valid
            {
                Console.WriteLine("The use of brackets is valid " + userInput);
            }
            else
            {
                Console.WriteLine("The use of brackets is invalid " + userInput);
            }
        }
    }
}

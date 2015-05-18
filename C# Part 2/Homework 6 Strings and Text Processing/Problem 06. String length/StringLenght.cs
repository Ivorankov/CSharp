using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

namespace Problem_06.String_length
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program adds some symbols to a text, sometimes...");
            Console.WriteLine("Write some text(max 20 characters!)");
            string userText = Console.ReadLine();
            string result = string.Empty;
            if (userText.Length < 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i < userText.Length)//for the lenght of the string
                    {
                        if (Char.IsLetter(userText[i]) || Char.IsDigit(userText[i]) || Char.IsSymbol(userText[i]))
                        {
                            result += userText[i];//adds letters , digits , symbols
                        }
                        else
                        {
                            result += ' ';//adds white space
                        }
                            
                        continue;
                    }
                    else
                    {
                        result += '*';//fills the remaining spaces with *
                    }
                }
            }
            Console.WriteLine("Result: {0}", result);
        }
    }
}

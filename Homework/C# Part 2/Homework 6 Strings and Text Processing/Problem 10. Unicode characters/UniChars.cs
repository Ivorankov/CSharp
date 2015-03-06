using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
namespace Problem_10.Unicode_characters
{
    class UniChars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program turns words into gibberish");
            Console.Write("Write some word: ");
            string userInput = Console.ReadLine();

            StringBuilder uniChar = new StringBuilder();
            foreach (var letter in userInput)
            {
                uniChar.AppendFormat("\\u{0:X4}", (int)letter);
            }
            Console.WriteLine(uniChar);
        }
    }
}

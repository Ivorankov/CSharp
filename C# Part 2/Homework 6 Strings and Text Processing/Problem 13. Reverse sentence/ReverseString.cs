using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reverses the words in given sentence.
namespace Problem_13.Reverse_sentence
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reverses sentences");
            Console.WriteLine("Write a sentece");
            string userText = Console.ReadLine();
            string[] text = new string[userText.Length - 1];
            char end = userText[userText.Length - 1];
            text = userText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            text = text.Reverse().ToArray();

            Console.WriteLine("{0}{1}", string.Join(" ", text), end);

        }
    }
}

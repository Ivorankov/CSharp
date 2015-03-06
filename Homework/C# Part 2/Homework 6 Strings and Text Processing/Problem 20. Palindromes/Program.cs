using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
namespace Problem_20.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program extracts palindromes, whatever thoese things are...");
            string text = "This is a test text. exe ABBA makes horrible music txt";
            string[] textSplit = text.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            string temp = string.Empty;
            foreach (var word in textSplit)
            {
                temp = Reverse(word);
                if (temp == word)//if its a palind.... 
                {
                    palindromes.Add(word);//The word goes in this list
                }
            }
            Console.WriteLine(text);
            foreach (var word in palindromes)
            {
                Console.WriteLine(word);
            }
        }
        private static string Reverse(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
namespace Problem_09.Forbidden_words
{
    class ForbidWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program censors sentences!");
            Console.WriteLine("Write some text with more then one sentence");
            string userText = Console.ReadLine();
            Console.WriteLine("Specify the words that will be cencored using (space) between each");

            string[] forbiddenWords = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] textArray = userText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //These two for loops run thru both arrays
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                for (int j = 0; j < textArray.Length; j++)
                {
                    if (textArray[j] == forbiddenWords[i])//If one of the words matches the forbidden one
                    {
                        userText = userText.Replace(textArray[j], new string('*', textArray[j].Length));//That word in the text is reaplaced by *
                    }
                }
            }
            Console.WriteLine(userText);
        }
    }
}

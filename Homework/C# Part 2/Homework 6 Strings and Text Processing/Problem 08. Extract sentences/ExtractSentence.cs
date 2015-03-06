using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.
namespace Problem_08.Extract_sentences
{
    class ExtractSentence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program extracts sentences");
            Console.WriteLine("Write some text with more then one sentence(coppy paste the example...)");
            string userText = Console.ReadLine();
            Console.WriteLine("Specify by what the sentences will be chosen ( if it contains (in) or something else..)");
            string userKey = Console.ReadLine();

            string[] sentences = userText.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);//Holds the entire text
            List<string> result = new List<string>();//THe sentences that contain the key word are added in this list

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);//Holds the words in the sentence
                foreach (var word in words)
                {
                    if (word == userKey)//If any of the words match the key the sentence is added in the list
                    {
                        result.Add(sentences[i]);
                        break;
                    }
                }
            }

            //This part prints the result in the console
            Console.WriteLine();
            foreach (var sentence in result)
            {
                Console.Write("{0} ", sentence);
            }
            Console.WriteLine();
        }
    }
}

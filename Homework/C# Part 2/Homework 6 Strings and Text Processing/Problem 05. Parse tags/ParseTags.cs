using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.

//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
namespace Problem_05.Parse_tags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program changes text depending on tags");
            Console.WriteLine("Write some text(surrounding parts of it with <upcase> </upcase> tags");
            string userText = Console.ReadLine();

            string result = SubStrings(userText);
            Console.WriteLine(result);

        }
        static string SubStrings(string text)
        {
            int indexStart = 0;
            int indexEnd = 0;
            int searchIndexS = 0;
            int searchIndexE = 0;
            string temp = string.Empty;
            string subStrStart = "<upcase>";
            string subStrEnd = "</upcase>";
            string substr = string.Empty;
            int lenght = 0;
            while (true)
            {
                indexStart = text.IndexOf(subStrStart, searchIndexS);
                indexEnd = text.IndexOf(subStrEnd, searchIndexE);
                //This moves the index so it can search for the substring in another place in the text
                searchIndexS = indexStart + 1;
                searchIndexE = indexEnd + 1;

                if (indexStart == -1 || indexEnd == -1)//If there aren't any more substrings 
                {
                    break;//Breaks the while loop
                }
                lenght = indexEnd - (indexStart + 9);//The lenght of the text between the tags
                substr = text.Substring(indexStart+8, lenght);//extracts the text between the tags
                text = text.Replace(substr, substr.ToUpper());//replaces it with upper case letters

            }
            return text;
        }
    }
}

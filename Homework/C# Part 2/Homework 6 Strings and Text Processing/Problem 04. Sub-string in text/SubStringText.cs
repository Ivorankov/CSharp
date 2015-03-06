using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
namespace Problem_04.Sub_string_in_text
{
    class SubStringText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds and counts specifyed parts in a text");
            Console.Write("Write some text: ");
            string userText = Console.ReadLine();
            Console.Write("Write the sub string you'll be looking for: ");
            string userSubString = Console.ReadLine();

            int result = SubStrings(userText,userSubString);
            Console.WriteLine("The sub-string {0} has been spotted {1} times in the text", userSubString, result);

        }
        static int SubStrings(string text,string subString)
        {
            int index = 0;
            int searchIndex = 0;
            int count = 0;

            while (true)
            {
                index = text.IndexOf(subString, searchIndex);//Starts searching from the [0] index 
                searchIndex = index + 1;//Then its starts searching from the last index +1
                count++;//counts the amount of sightings
                if (index == -1)
                {
                    if (count > 0)
                    {
                        count--;
                        return count;//IF there are sightings of the substring we have to do -1 (because even when index becomes -1 count will get increased +1)
                    }
                    else
                    {
                        count--;
                        return count;

                    }
                }
            }
        }
    }
}

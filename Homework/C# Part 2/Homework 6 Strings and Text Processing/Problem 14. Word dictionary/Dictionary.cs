using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
namespace Problem_14.Word_dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program translates words");

            Dictionary<string,string> holder = new Dictionary<string,string>();
            holder.Add(".NET", "platform for applications from Microsoft");
            holder.Add("CLR", "managed execution environment for .NET");
            holder.Add("namespace", "hierarchical organization of classes");
            Console.Write("Enter (.NET) or (CLR) or (namespace): ");
            string userInput = Console.ReadLine();

            //Auto test....
            //string[] result = {
            //                      ".NET",
            //                      "CLR",
            //                      "namespace"
            //                  };
            //for (int i = 0; i < result.Length; i++)
            //{
            //    if (holder.ContainsKey(result[i]))//If matches to a key from the dictionary
            //    {
            //        Console.WriteLine(holder[result[i]]);//Gets the value 
            //    }
            //}

            if (holder.ContainsKey(userInput))
            {
                Console.WriteLine("{0} - {1}", userInput, holder[userInput]);
            }
            else
            {
                Console.WriteLine("{0} is not contained in the dictionary", userInput);
            }
        }
    }
}

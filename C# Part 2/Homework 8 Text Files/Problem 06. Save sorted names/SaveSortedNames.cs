using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a text file containing a list of strings,
//sorts them and saves them to another text file.
namespace Problem_06.Save_sorted_names
{
    class SaveSortedNames
    {
        static void Main()
        {
            List<string> allString = new List<string>();
            string currentLine = null;
            using (StreamReader reader = new StreamReader("../../TextFile.txt"))
            {
                currentLine = reader.ReadLine();
                for (int i = 0; currentLine != null; i++)
                {
                    allString.Add(currentLine);
                    currentLine = reader.ReadLine();
                }
            }
            allString.Sort();
            using (StreamWriter writer = new StreamWriter("../../Result.txt"))
            {
                for (int i = 0; i < allString.Count; i++)
                {
                    writer.WriteLine(allString[i]);
                }
            }
            Console.WriteLine("Sorting completed (check the project folder");
        }
    }
}

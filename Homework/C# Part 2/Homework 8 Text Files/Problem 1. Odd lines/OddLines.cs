using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Odd_lines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../text.txt");
            using (reader)
            {
                int lineNumber = 0;
                string lineOfText = reader.ReadLine();
                while (lineOfText != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 != 0) //If you delete this line you can see the whole text
                    {
                        Console.WriteLine(lineOfText);
                    }
                    lineOfText = reader.ReadLine();
                }
            }
        }
    }
}
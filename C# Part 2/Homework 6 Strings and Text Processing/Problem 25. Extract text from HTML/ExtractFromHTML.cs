using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
namespace Problem_25.Extract_text_from_HTML
{
    class ExtractFromHTML
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program extracts content from HTML files");
            string HTML = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

            string template = "(?<=^|>)[^><]+?(?=<|$)";
            List<string> content = new List<string>();
            foreach (Match item in Regex.Matches(HTML, template))
            {
                content.Add(item.ToString());
            }

            foreach (var sentence in content)
            {
                Console.WriteLine(sentence);
            }

        }
    }
}

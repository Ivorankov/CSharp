using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Input: (copy paste to console for easyer testing...)
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
namespace Problem_15.Replace_tags
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tag replacer 2.0!");
            Console.WriteLine("Write the HTML content: ");
            string htmlInput = Console.ReadLine();

            string switchTag =  htmlInput.Replace(@"<a href=""", "[URL=");
            switchTag = switchTag.Replace(@""">", "]");
            switchTag = switchTag.Replace("</a>", "/URL]");

            Console.WriteLine("Here is the result: ");
            Console.WriteLine(switchTag);
            
        }
    }
}

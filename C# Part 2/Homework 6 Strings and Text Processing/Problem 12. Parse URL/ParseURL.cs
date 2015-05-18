using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example: http://telerikacademy.com/Courses/Courses/Details/212
namespace Problem_12.Parse_URL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program breaks down uri addresses");
            var uri = new Uri("http://telerikacademy.com/Courses/Courses/Details/212");//URI class at work :D 
            Console.WriteLine(uri);

            string protocol = uri.Scheme;
            string server = uri.Host;
            string test2 = uri.AbsolutePath;

            Console.WriteLine("Protool: " + protocol);
            Console.WriteLine("Server: " + server);
            Console.WriteLine("Resource: " + test2);
        }
    }
}
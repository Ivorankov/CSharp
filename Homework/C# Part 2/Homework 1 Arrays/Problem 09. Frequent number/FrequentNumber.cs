using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the most frequent number in an array.
namespace Problem_09.Frequent_number
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { };
            List<int> bufferList = new List<int>();
            Console.WriteLine("This program finds the most common number in an array");

            //This part fills the array from the user input
            Console.Write("Enter some numbers using(,)or(space) between them: ");
            array = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            var results = array.GroupBy(value => value) // group the array by value
                               .Select(number => new
                               { // for each group select the value (key) and the number of items into an anonymous object
                                   Key = number.Key,
                                   Count = number.Count()
                               })
                               .OrderByDescending(order => order.Count); // order the results by count(number that reapets the most)

            //I use a foreach to get the contets of results printed in the console, because idk how to print just the first ones....
            foreach (var result in results)
            {
                Console.WriteLine("\nNumber: {0} Count: {1}", result.Key, result.Count);
                break;//So I use break, problem solved....kinda...
            }
        }
    }
}

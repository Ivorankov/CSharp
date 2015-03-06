using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
namespace Problem_05.Sort_by_string_length
{
    class SortByLenght
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program lets you create an array and then its sorts it for you");

            string[] userArray = new string[] { };

            //This part fills the userArray
            Console.WriteLine("Please fill the array with numbers using (space) between each");
            userArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToArray();

            Console.WriteLine("\nThere are 2 sorting methods at play..");
            Console.WriteLine("This is the first one -");
            HarderSort(userArray);
            Console.WriteLine("This is the second one - ");
            EasyerWay(userArray);
          
        }

        public static void HarderSort(string[] userArray)
        {


            //This creates an IEnumerable containing the sorted array , other way would be with .Sort but this was more fun :D 
            var tempSorted = userArray.OrderBy(x => x.Length);
            //Then it goes in a list
            List<string> sortedArray = new List<string>(tempSorted);

            //This part prints the result in the console
            Console.WriteLine("Your array was sorted by the lenght of its components");
            foreach (string item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }
        public static void EasyerWay(string[] userArray)
        {
            //Sorting it using .Sort
            Array.Sort(userArray, (x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine("Your array was sorted by the lenght of its components");
            foreach (string item in userArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}


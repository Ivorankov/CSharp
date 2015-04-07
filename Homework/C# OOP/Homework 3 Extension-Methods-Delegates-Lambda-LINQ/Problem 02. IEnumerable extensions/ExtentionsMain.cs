//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
namespace Problem_02.IEn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Extention;//Importaint to add the namespace!
    using System.Text;
    class ExtMain
    {
        static void Main()
        {
            IEnumerable<double> test = new double[] { 1, 2, 3, 4.5, 5.5, -9 };
            string collection = CollectionContent(test);
            Console.WriteLine("The collection is: " +  collection);
            Console.WriteLine("The sum of the numbers is: " + test.SumOfCollection());
            Console.WriteLine("The product of the numbers is: " + test.Product());
            Console.WriteLine("The min number is: " + test.MinValue());
            Console.WriteLine("The max number is: " + test.MaxValue());
            Console.WriteLine("The average of the numbers is: " + test.AverageValue());
        }
        private static string CollectionContent<T>(IEnumerable<T> collection)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in collection)
            {
                result.Append(item + ", ");
            }
            return result.ToString();
        }
    }
}

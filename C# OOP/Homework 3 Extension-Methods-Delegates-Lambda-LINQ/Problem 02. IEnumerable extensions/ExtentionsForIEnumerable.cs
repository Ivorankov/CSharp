namespace Extention
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
   public static class Extentions
    {
        public static T SumOfCollection<T>(this IEnumerable<T> content) 
        {
            T sum = default(T);
            foreach (var number in content)
            {
                sum += (dynamic)number;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> content)
        {
            T product = (dynamic)1;
            foreach (var number in content)
            {
                product *= (dynamic)number;
            }
            return product;
        }
        public static T MinValue<T>(this IEnumerable<T> content) where T: IComparable
        {
            T min = content.ElementAt(0);
            foreach (var number in content)
            {
                if (number.CompareTo(min) == -1)
                {
                    min = number;
                }
            }
            return min;
        }
        public static T MaxValue<T>(this IEnumerable<T> content) where T : IComparable
        {
            T max = content.ElementAt(0);
            foreach (var number in content)
            {
                if (number.CompareTo(max) == 1)
                {
                    max = number;
                }
            }
            return max;
        }
        public static T AverageValue<T>(this IEnumerable<T> content) where T : IComparable
        {
            T result = default(T);
            int count = 0;
            foreach (var number in content)
            {
                result += (dynamic)number;
                count++;
            }
            result = (dynamic)result / count;
            return result;
        }
    }
}

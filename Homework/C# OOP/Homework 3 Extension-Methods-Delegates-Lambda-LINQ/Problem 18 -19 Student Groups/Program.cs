
//Problem 18 - Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//Use LINQ.

//Problem 19 - Rewrite the previous using extension methods.
namespace Problem_18__19_Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new{ FirstName = "Albert", LastName = "Einstein",GroupNumber = 1},
                new{ FirstName = "Bob", LastName = "Dillan",GroupNumber = 2},
                new{ FirstName = "Carmen", LastName = "Electra",GroupNumber = 2},
                new{ FirstName = "David", LastName = "Guetta",GroupNumber = 3},
                new{ FirstName = "Ernest", LastName = "Hemingway",GroupNumber = 1},
            };
            Console.WriteLine("Ordering the students using LINQ\n");
            var groupedStudents =
                from student in students
                orderby student.GroupNumber
                select student;
            foreach (var student in groupedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\nOrdering the students using extention\n");
            var groupedStudentsExt = groupedStudents.GroupStudents();
            foreach (dynamic student in groupedStudentsExt)
            {
                Console.WriteLine(student);
            }
        }
    }
    public static class Extentions
    {
        public static IEnumerable<T> GroupStudents<T>(this IEnumerable<T> arrayOfStudents) 
        {
            var type = typeof(T);
            MethodInfo[] getters = type.GetProperties().Select(pi => pi.GetGetMethod()).ToArray();//reflection will allow to call the props from the anonymous class
            var orderedStudents = arrayOfStudents.OrderBy(x => getters[2]);//Group number is located at index 2...
            return orderedStudents;
        }
    }
}

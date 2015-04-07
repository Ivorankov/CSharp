
    //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
    //by first name and last name in descending order.
    //Rewrite the same with LINQ.

namespace Problem_05.Order_students
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    class OrderStudents
    {
        static void Main(string[] args)
        {
            Stopwatch test = new Stopwatch();//Just having some fun...
            var students = new[]
            {
                new{ FirstName = "Albert", LastName = "Einstein"},
                new{ FirstName = "Bob", LastName = "Dillan"},
                new{ FirstName = "Carmen", LastName = "Electra"},
                new{ FirstName = "David", LastName = "Guetta"},
                new{ FirstName = "Ernest", LastName = "Hemingway"},
            };
            Console.WriteLine("Lambda sorting test \n");
            test.Start();
            var sortedStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            test.Stop();
            Console.WriteLine("It took " + test.Elapsed + "s to sort the students");
            test.Reset();
            Console.WriteLine("\nLINQ sorting test \n");
            test.Start();
            var sortedStudentsLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            foreach (var student in sortedStudentsLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            test.Stop();
            Console.WriteLine("It took " + test.Elapsed + "s to sort the students");
            //The stopwatch lies, if both are tested individually they give the same time...
        }
    }
}

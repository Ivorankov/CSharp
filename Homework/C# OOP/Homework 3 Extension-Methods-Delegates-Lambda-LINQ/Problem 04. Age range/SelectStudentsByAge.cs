
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace Problem_04.Age_range
{
    using System;
    using System.Linq;
    class SelectStudentsByAge
    {
        static void Main()
        {
            var students = new[]
            {
                new{ FirstName = "Timmy", LastName = "Dorko", Age = 18},
                new{ FirstName = "Jennifer", LastName = "Alison", Age = 22},
                new{ FirstName = "Jack", LastName = "Lumberjack", Age = 49},
                new{ FirstName = "Shashka", LastName = "Vaseva",Age = 60},
                new{ FirstName = "Johnny", LastName = "Smartass",Age = 11},
            };
            var matchStudents =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;
            foreach (var student in matchStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}

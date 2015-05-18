
    //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    //Use LINQ query operators.

namespace Problem_03.First_before_last
{
    using System;
    using System.Linq;
    class SelectStudents
    {
        static void Main()
        {
            var students = new[]
            {
                new{ FirstName = "Alex", LastName = "Robinson"},
                new{ FirstName = "Sara", LastName = "Alexanria"},
                new{ FirstName = "John", LastName = "Damadjanov"},
                new{ FirstName = "Perta", LastName = "Petrova"},
            };
            var matchStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;
            foreach (var student in matchStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}

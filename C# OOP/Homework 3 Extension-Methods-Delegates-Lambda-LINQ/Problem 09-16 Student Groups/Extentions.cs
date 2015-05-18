//Problem 10 -Implement the previous using the same query expressed with extension methods

//Problem 14 - Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

namespace Problem_09_16_Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class Extentions
    {
        //Problem 10
        public static IOrderedEnumerable<Student> SortStudents(this List<Student> students)
        {
            var selectedStudents =
                from student in students
                where student.GropuNumber == 2
                orderby student.FirstName
                select student;
            return selectedStudents;
        }
        //Problem 14
        public static IEnumerable<Student> SelectStudent(this List<Student> students)
        {
            var selectedStudents =
                from student in students
                where student.Marks.Count == 2
                select student;
            return selectedStudents;
        }
    }
}

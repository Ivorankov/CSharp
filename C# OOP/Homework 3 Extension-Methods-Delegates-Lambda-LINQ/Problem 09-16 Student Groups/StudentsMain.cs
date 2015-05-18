
//Problem 11 - Extract all students that have email in abv.bg.
//Use string methods and LINQ.

//Problem 12 - Extract all students with phones in Sofia.
//Use LINQ.

//Problem 13  Select all students that have at least one mark Excellent (6)
//into a new anonymous class that has properties – FullName and Marks.Use LINQ.

//Problem 14 - Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

//Problem 15 - Extract all Marks of the students that enrolled in 2006.
//(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
namespace Problem_09_16_Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    class StudentsMain
    {
        static void Main()
        {
            //Problem 9
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("John", "Doe", "example@mail.net", new List<double>{ 4.52 , 6.00}, 1, "000106", ""));
            listOfStudents.Add(new Student("Jane", "Doe", "badBit@mail.com", new List<double> { 3.65, 5.46 }, 1, "000206", ""));
            listOfStudents.Add(new Student("Mark", "Night", "Im_da_Best@best.com", new List<double> { 4.52 }, 2, "000307", ""));
            listOfStudents.Add(new Student("Jennifer", "Marksmen", "hotthing@mail.net", new List<double> { 3.68 , 2.00 }, 2, "000409", ""));
            listOfStudents.Add(new Student("Orhan", "Murat", "badMusic@garbage.net", new List<double> { 6.00 , 2.25 }, 3, "000510", ""));
            listOfStudents.Add(new Student("Josh", "Smartass", "iLoveJezus@abv.bg", new List<double> { 6.00 , 6.00 }, 4, "000606", "02264785"));
            listOfStudents.Add(new Student("Trish", "Tengereen", "trish@abv.bg", new List<double> { 3.00 }, 4, "000707", "09264785698"));

            var selectedStudents =
                from student in listOfStudents
                where student.GropuNumber == 2
                orderby student.FirstName
                select student;
            Console.WriteLine("PROBLEM 9:");
            Console.WriteLine("Selected students from group 2 and ordered by first name\n");
            PrintStudents(selectedStudents);
            ClearConsole();

            //Problem 10(also includes Extentions class)
            Console.WriteLine("Problem 10:");
            Console.WriteLine("Selected students from group 2 and ordered by first name(using the extention)\n");
            var extentionTest = listOfStudents.SortStudents();
            PrintStudents(extentionTest);
            ClearConsole();

            //Problem 11
            Console.WriteLine("PROBLEM 11:");
            Console.WriteLine("Selected students with email in abv.bg\n");
            var selectStudentsByMail =
                from student in listOfStudents
                where student.EMail.Contains("abv.bg")
                select student;
            PrintStudents(selectStudentsByMail);
            ClearConsole();

            //Problem 12
            Console.WriteLine("PROBLEM 12:");
            Console.WriteLine("Selected students with phone numbers in Sofia\n");
            var selectedStudentsByPhone =
                from student in listOfStudents
                where student.PhoneNumber.StartsWith("02")
                select student;
            PrintStudents(selectedStudentsByPhone);
            ClearConsole();

            //Problem 13
            Console.WriteLine("PROBLEM 13:");
            Console.WriteLine("Selected students with at least 1 excelent mark\n");
            var selectedStudentsByMark =
                from student in listOfStudents
                where student.Marks.Contains(6.00)
                select new { FullName = student.FirstName + " " + student.LastName, Makrs = student.Marks };
            foreach (var student in selectedStudentsByMark)
            {
                Console.WriteLine(student.FullName);
                student.Makrs.ForEach(x => Console.WriteLine(x));//All this does is print the marks from the list(otherwise we get System.List....)
            }
            ClearConsole();

            //Problem 14
            Console.WriteLine("PROBLEM 14:");
            Console.WriteLine("Selected students with two marks\n");
            var selectedStudentsByTwoMarks = listOfStudents.SelectStudent();
            PrintStudents(selectedStudentsByTwoMarks);
            ClearConsole();

            //Problem 15
            Console.WriteLine("PROBLEM 15:");
            Console.WriteLine("Selected marks from students sighned in 2006\n");
            var selectedStudentsByFN =
                from student in listOfStudents
                where student.FacultetNumber.EndsWith("06")
                select student;
            foreach (var student in selectedStudentsByFN)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);//It sayd extract the marks but i put the names aswell...
                student.Marks.ForEach(x => Console.WriteLine(x));
                Console.WriteLine();
            }
            ClearConsole();

            //Problem 16*
            List<Group> groups = new List<Group>();
            groups.Add(new Group(1, "Mathematics"));
            groups.Add(new Group(3, "Phisycs"));

            var selectedStudentsByGropuNumber =
                from student in listOfStudents
                join gr in groups on student.GropuNumber equals gr.GroupNumber
                where gr.GroupNumber == 1
                select student;
            PrintStudents(selectedStudentsByGropuNumber);
            ClearConsole();
        }
        //I got tired of copy/pasting so I made some methods... :D
        static void ClearConsole()
        {
            Console.WriteLine("Clearing the console in 10 sec...");
            Thread.Sleep(10000);
            Console.Clear();
        }
        static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

namespace Problem_02_Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using People;
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Alex","Jones",5.12),
                new Student("Tom","Hanks",2.00),
                new Student("Jeffry","Jones",4.14),
                new Student("Tom","Jerry",6.00),
                new Student("John","Doe",4.65),
                new Student("Jane","Doe",5.45),
                new Student("Borat","Sagdiyev",6.00),
                new Student("Kate","Moss",3),
                new Student("Tim","Black",4.23),
                new Student("Josh","Fox",3.68),
            };
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Omaha","Croratov",485,8),
                new Worker("Alex","Dimitrov",300,7),
                new Worker("Cura","Grabadgeov",180,8),
                new Worker("Garet","Falon",600,4),
                new Worker("Tory","Kissass",500,12),
                new Worker("Tara","Chuntova",320,7),
                new Worker("Ursula","Smirnoff",560,9),
                new Worker("Mustafa","Sandal",180,10),
                new Worker("Tara","Smith",360,8),
                new Worker("John","Smith",360,8),
            };
            Console.WriteLine("Sorted students by grade:\n");
            var sortedStudents = students.OrderBy(x => x.Grade).ToList();
            sortedStudents.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + " Grade: " + x.Grade));//<3 list extention methonds :D
            Console.WriteLine("\nSorted workes by money per hour\n");
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
            sortedWorkers.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + " Money per hour: " + x.MoneyPerHour().ToString("C2")));
            Console.WriteLine("\nConcated list sortend by first and last name\n");
            var concatLists = sortedStudents.Concat<Human>(sortedWorkers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            concatLists.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));
            
        }
    }
}

namespace SchoolTest
{
    using System;
    using System.Collections.Generic;
    using Persons;//I desided to have some fun with the namespaces :D 
    using School;

    class SchoolMain
    {
        static void Main()
        {

            //Creating techers
            Teacher testTeacher1 = new Teacher("Abraham","Lincon");
            testTeacher1.AddDiscipline(new Discipline("Math", 10, 10));
            testTeacher1.AddDiscipline(new Discipline("Mechanics", 25, 15));
            Teacher testTeacher2 = new Teacher("Tom", "Hanks");
            testTeacher2.AddDiscipline(new Discipline("Math", 10, 10));
            testTeacher2.AddDiscipline(new Discipline("Sudo Science", 25, 15));
            Teacher testTeacher3 = new Teacher("Jenny", "Ogle");
            testTeacher3.AddDiscipline(new Discipline("Pholosopy", 10, 10));
            testTeacher3.AddDiscipline(new Discipline("Biology", 25, 15));

            //Creating students
            Student testStudent1 = new Student("Josh", "Fox", 1);
            Student testStudent2 = new Student("Jane", "Doe", 2);
            Student testStudent3 = new Student("John", "Doe", 3);

            //Creating class/adding students and teachers to it
            Class classA = new Class("Class A");
            classA.AddTeacher(testTeacher1);
            classA.AddTeacher(testTeacher3);

            classA.AddStudent(testStudent1);
            classA.AddStudent(testStudent3);

            Class classB = new Class("Class B");
            classB.AddStudent(testStudent2);
            classB.AddStudent(testStudent1);

            classB.AddTeacher(testTeacher2);
            classB.AddTeacher(testTeacher1);

            var listOfClasses = new List<Class>();
            listOfClasses.Add(classA);
            listOfClasses.Add(classB);
            //Creating a school
            School theBestSchool = new School("Albert J Von", "22 J Street", "www.Albr.com", listOfClasses);

            //Printing the contents...
            foreach (var item in theBestSchool.Classes)
            {
                Console.WriteLine(item.ClassName);
                Console.WriteLine("Students");
                item.StudentsInClass.ForEach(x => Console.WriteLine(x.ToString()));
                Console.WriteLine("Teachers");
                item.TeachersInClass.ForEach(x => Console.WriteLine(x.ToString()));
            }

        }
    }
}

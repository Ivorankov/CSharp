namespace Problem_01_03_Students
{
    using System;
    class Program
    {
        static void Main()
        {
            Student testStudent = new Student("John", "John", "Adams", "S21S", "WoodLand 210", "+351 12 12 12", "mail@mail.com",
                Enumerators.University.Harvard, 2, Enumerators.Faculty.ComputerScience, Enumerators.Speciality.Programmer);
            Student testStudent2 = new Student("Alex", "John", "Adams", "S21S6", "WoodLand 21", "+351 12 12 12", "mail@mail.com",
                Enumerators.University.Stanfornd, 2, Enumerators.Faculty.NuclearPhisycs, Enumerators.Speciality.MadScientist);
            //ToString tests
            Console.WriteLine(testStudent.ToString());
            Console.WriteLine(testStudent2.ToString());
            //Equals test
            Console.WriteLine(testStudent == testStudent2);
            Console.WriteLine(testStudent != testStudent2);
            Console.WriteLine(testStudent.Equals(testStudent2));
            //Get hash code test
            Console.WriteLine(testStudent.GetHashCode());
            Console.WriteLine(testStudent2.GetHashCode());
            //Clone test
            var newStudent = testStudent.Clone();
            Console.WriteLine(newStudent);
            //CompareTO test
            Console.WriteLine(testStudent.CompareTo(testStudent2));
        }
    }
}

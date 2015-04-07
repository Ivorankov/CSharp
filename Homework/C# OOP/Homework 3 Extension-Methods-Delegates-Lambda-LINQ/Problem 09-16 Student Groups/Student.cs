
    //Problem 9 -Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    //Create a List<Student> with sample students. Select only the students that are from group number 2.
    //Use LINQ query. Order the students by FirstName.

namespace Problem_09_16_Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
   public class Student
    {
       private string phoneNumber;

       //Problem 9
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public List<double> Marks { get; set; }
        public int GropuNumber { get; set; }//In problem 16 its sayd to introduce this property(but it was introduced in problem 9 ?:O)
        public string FacultetNumber { get; set; }//I assumed FN meant facultet number
        public string PhoneNumber 
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public Student(string firstName, string lastName, string eMail, List<double> marks, int groupNumber, string facultetNumber, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
            this.Marks = marks;
            this.GropuNumber = groupNumber;
            this.FacultetNumber = facultetNumber;
            this.PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            StringBuilder marks = new StringBuilder();//Making the marks a list made my life a living hell...(stupid Problem 14)
            foreach (var mark in Marks)
            {
                marks.Append(mark + " ");
            }
            return string.Format("First name: {0}\nLast name: {1}\nEmail: {2}\nMark: {3:F2}\nGroup number: {4}\nFacultet number: {5}\nPhone number: {6}\n",
                FirstName, LastName, EMail, marks , GropuNumber, FacultetNumber,PhoneNumber);
        }
    }
}

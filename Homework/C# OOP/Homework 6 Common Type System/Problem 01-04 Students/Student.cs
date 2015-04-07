namespace Problem_01_03_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enumerators;
    public class Student : ICloneable,IComparable<Student>
    {
        //Problem 1
        public Student(string firstName, string middleName, string lastName, string SSN,
            string address, string phoneNumber, string eMail, University university,
            int course,Faculty faculty, Speciality speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.EMail = eMail;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string SSN { get; private set; }//social security number ?
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public string EMail { get; private set; }
        public University University { get; private set; }
        public int Course { get; private set; }
        public Faculty Faculty { get; private set; }
        public Speciality Speciality { get; private set; }
        //Yes there are no validations - But there was no mention of validation in the task....so please dont judge me :D 

        public override string ToString()
        {
            return string.Format("{0} {1} {2}\nSSN: {3}\nAddress: {4}\nPhone number: {5}\nEmail: {6}\nUniversity: {7}\nFaculty: {8}\nSpeciality: {9}",
                FirstName, MiddleName, LastName, SSN, Address, PhoneNumber, EMail, University, Faculty, Speciality);
        }
        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (this.SSN == student.SSN)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SSN.GetHashCode();
        }
        //Problme 2
        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
                this.PhoneNumber, this.EMail, this.University, this.Course, this.Faculty, this.Speciality);
        }
        //Problem 3
        public int CompareTo(Student other)
        {
            var nameOfStudent = this.FirstName + this.MiddleName + this.LastName;
            var nameOfOther = other.FirstName + other.MiddleName + other.LastName;
            if (nameOfStudent == nameOfOther)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            return nameOfStudent.CompareTo(nameOfOther);
        }
    }
}

namespace School
{
    using System;
    using System.Collections.Generic;
    using Persons;
    public class Class
    {
        private string className;
        private List<Teacher> teachersInClass = new List<Teacher>();
        private List<Student> studentsInClass = new List<Student>();

        public string ClassName
        {
            get { return this.className; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Class name must contain at least 2 symbols");
                }
                this.className = value;
            }
        }
        public List<Teacher> TeachersInClass
        {
            get { return this.teachersInClass; }
            private set { this.teachersInClass = value; }
        }
        public List<Student> StudentsInClass
        {
            get { return this.studentsInClass; }
            private set { this.studentsInClass = value; }
        }
        public Class(string className)
        {
            this.ClassName = className;
        }
        public void AddTeacher(Teacher teacher)
        {
            this.TeachersInClass.Add(teacher);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            this.TeachersInClass.Remove(teacher);
        }
        public List<Teacher> GetTeachers()
        {
            return this.TeachersInClass;
        }
        public void AddStudent(Student student)
        {
            this.StudentsInClass.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            this.StudentsInClass.Remove(student);
        }
        public List<Student> GetStudents()
        {
            return this.StudentsInClass;
        }
    }
}


//Problem 16 - Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.
//Use the Join operator.
namespace Problem_09_16_Student_Groups
{
    using System;
    class Group
    {
        public int GroupNumber { get; set; }
        public string Department { get; set; }

        public Group(int groupNumber, string department)
        {
            this.GroupNumber = groupNumber;
            this.Department = department;
        }
    }
}

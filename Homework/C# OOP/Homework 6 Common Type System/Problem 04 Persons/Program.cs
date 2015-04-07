namespace Problem_04_Persons
{
    using System;

    class Program
    {
        public static void Main()
        {
            var person = new Person("Homer Simpson", 12);
            Console.WriteLine(person);
            var otherPerson = new Person("Marge Simpson");
            Console.WriteLine(otherPerson);
        }
    }
}

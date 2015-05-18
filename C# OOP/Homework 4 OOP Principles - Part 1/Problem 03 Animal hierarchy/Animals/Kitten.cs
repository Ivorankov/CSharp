namespace Animals
{
    using System;
    using Animals.Enumerators;
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, Gender.Female, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Prrrrrrr");
        }
    }
}

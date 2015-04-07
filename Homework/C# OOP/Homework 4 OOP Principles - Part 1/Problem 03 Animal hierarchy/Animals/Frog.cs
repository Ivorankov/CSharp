namespace Animals
{
    using System;
    using Animals.Enumerators;

    public class Frog : Animal
    {
        public Frog(string name, Gender gender, int age)
            : base(name, gender, age)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}

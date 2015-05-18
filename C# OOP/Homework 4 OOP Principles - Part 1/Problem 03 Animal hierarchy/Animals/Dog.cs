namespace Animals
{
    using System;
    using Animals.Enumerators;
    public class Dog : Animal
    {
        public Dog(string name, Gender gender, int age)
            : base(name, gender, age)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark bark!");
        }
    }
}

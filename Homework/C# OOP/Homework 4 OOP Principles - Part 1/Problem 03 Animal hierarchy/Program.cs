namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Animals.Enumerators;

    class Program
    {
        static void Main()
        {
            var listOfAnimals = new List<Animal>()
            {
                new TomCat("Tom",4),
                new Kitten("Jerrina",3),
                new Dog("Muttly",Gender.Male,1),
                new Frog("Frogly",Gender.Female,2)
            };
            Console.WriteLine("The average age of the animals is: " + CalcAverageAge(listOfAnimals));

            Console.WriteLine("That was easy... heres some more tests...");
            listOfAnimals[0].MakeSound();
            listOfAnimals[1].MakeSound();
            listOfAnimals[2].MakeSound();
            listOfAnimals[3].MakeSound();
        }
        static double CalcAverageAge(List<Animal> animals)
        {
            double result = 0;
            foreach (var animal in animals)
            {
                result += animal.Age;
            }
            result = result / animals.Count;
            return result;
        }
    }
}

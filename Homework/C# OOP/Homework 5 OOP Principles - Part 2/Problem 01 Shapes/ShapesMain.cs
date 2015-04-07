namespace Problem_01_Shapes
{
    using System;
    using System.Collections.Generic;
    class ShapesMain
    {
        static void Main()
        {
            List<Shape> someShapes = new List<Shape>()
            {
                new Recktangle(2.5,3.5),
                new Square(5),
                new Triangle(2,5)
            };
            //And now the testing
            Console.WriteLine("Recktangle surface area..");
            Console.WriteLine(someShapes[0].CalcSurfaceArea());
            Console.WriteLine("Square surface area..");
            Console.WriteLine(someShapes[1].CalcSurfaceArea());
            Console.WriteLine("Triangle surface area..");
            Console.WriteLine(someShapes[2].CalcSurfaceArea());
            //Wow those were some serious tests pfewww..
        }
    }
}

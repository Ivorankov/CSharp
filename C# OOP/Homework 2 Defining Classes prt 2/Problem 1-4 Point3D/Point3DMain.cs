
namespace Problem_1_4_Point3D
{
    using System;
    class Point3DMain
    {
        static void Main()
        {
            //Testing the Point/Distance class
            Point3D testPoint = new Point3D(2, 3, 3);
            Point3D pointZero = new Point3D();

            Console.WriteLine("Distance between point O and random point: {0}", DistanceCalc.DistanceBetweenPoints(pointZero, testPoint));

            //Testing Path/Pathstorage class
            Path testPath = new Path();
            testPath.AddPoint(pointZero);
            testPath.AddPoint(testPoint);

            PathStorage.Save(testPath);
            Console.WriteLine("The points have been saved in a txt file");

            Console.WriteLine("Loading the points from the file...");
            Path loadedPath = PathStorage.Load();
            for (int i = 0; i < loadedPath.ListOfPoints.Count; i++)
            {
                Console.WriteLine(loadedPath.ListOfPoints[i]);
            }
        }
    }
}

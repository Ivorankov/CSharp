
namespace Problem_1_4_Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    static class PathStorage
    {
        //Problem 4
        private static string filePath = @"..\..\PointStorage.txt";

        public static void Save(Path newPath)
        {
            using (StreamWriter savePath = new StreamWriter(filePath))
            {
                int count = newPath.ListOfPoints.Count;
                for (int i = 0; i < count; i++)
                {
                    savePath.WriteLine(newPath.ListOfPoints[i]);
                }
            }
        }
        public static Path Load()
        {
            Path path = new Path();

            using (StreamReader loadPath = new StreamReader(filePath))
            {
                while (loadPath.EndOfStream == false)
                {
                    string line = loadPath.ReadLine();
                    double[] points = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>double.Parse(x)).ToArray();
                    path.AddPoint(new Point3D(points[0], points[1], points[2]));
                }
            }
            return path;
        }
    }
}

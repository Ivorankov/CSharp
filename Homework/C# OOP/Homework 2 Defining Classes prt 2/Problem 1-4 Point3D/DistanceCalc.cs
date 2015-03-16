
namespace Problem_1_4_Point3D
{
    using System;
    static class DistanceCalc
    {
        //Problem 3
        public static double DistanceBetweenPoints(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt((first.X - second.X) * (first.X - second.X)
                + (first.Y - second.Y) * (first.Y - second.Y)
                + (first.Z - second.Z) * (first.Z - second.Z));
            return distance;
        }
    }
}

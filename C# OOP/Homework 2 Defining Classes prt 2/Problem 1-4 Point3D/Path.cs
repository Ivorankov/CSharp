
namespace Problem_1_4_Point3D
{
    using System;
    using System.Collections.Generic;
    class Path
    {
        //Problem 4
        private List<Point3D> listOfPoints = new List<Point3D>();

        public Path()
        {
            this.ListOfPoints = listOfPoints;
        }

        public List<Point3D> ListOfPoints { get; set; }

        public void AddPoint(Point3D newPoint)
        {
            listOfPoints.Add(newPoint);
        }
    }
}

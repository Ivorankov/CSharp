
namespace Problem_1_4_Point3D
{
    using System;
    public struct Point3D
    {
        private double x;//Problem 1
        private double y;
        private double z;

        private static readonly Point3D pointZero;//Problem 2

        public Point3D(double x, double y, double z) : this()//Problem 1
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        static Point3D()//Problem 2
        {
            pointZero = new Point3D(0, 0, 0);
        }
        public double X//Problem 1
        {
            get { return x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return z; }
            set { this.z = value; }
        }

        static Point3D PointZero { get; set; }//Problem 2

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.x, this.y, this.z);
        }
    }
}

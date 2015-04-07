namespace Problem_01_Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double height,double width)
            :base(height,width)
        {

        }
        public override double CalcSurfaceArea()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}

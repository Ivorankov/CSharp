namespace Problem_01_Shapes
{
    using System;
    public class Square : Recktangle
    {
        public Square(double width)
            :base(width)
        {

        }
        public override double CalcSurfaceArea()
        {
            return this.Width * this.Width;
        }
    }
}

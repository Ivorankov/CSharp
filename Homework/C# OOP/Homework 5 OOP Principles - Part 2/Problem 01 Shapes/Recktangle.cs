using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_01_Shapes
{
    public class Recktangle : Shape
    {
        public Recktangle(double height, double width)
            :base(height,width)
        {

        }
        public Recktangle(double height)
            :base(height)
        {

        }
        public override double CalcSurfaceArea()
        {
            return this.Height * this.Width;
        }
    }
}

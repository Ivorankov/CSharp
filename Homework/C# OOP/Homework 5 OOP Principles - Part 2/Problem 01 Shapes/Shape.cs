using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_01_Shapes
{
    public abstract class Shape
    {
        private double width;
        private double hight;
        public double Height
        {
            get { return this.hight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height value cannot be less then or equal to 0.");
                }
                this.hight = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width value cannot be less then or equal to 0.");
                }
                this.width = value;
            }
        }
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public Shape(double width)//Needed for the square class...
        {
            this.Width = width;
        }
        public virtual double CalcSurfaceArea()
        {
            return 0;
        }
    }
}

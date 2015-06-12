using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncapsulationAndPolymorphismHW
{
    public class Rectangle : BasicShape
    {
        public override double CalculateArea()
        {
            return 2*(Height + Width);
        }

        public override double CalculatePerimeter()
        {
            return Height * Width;
        }

        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} with perimeter {1:F2} and area {2:F2}", this.GetType().Name, this.CalculatePerimeter(),
                this.CalculateArea());
        }
    }
}

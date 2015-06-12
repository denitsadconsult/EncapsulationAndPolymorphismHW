using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncapsulationAndPolymorphismHW
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                this.radius = value;

                if (radius < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius must always be a positive value.");
                }
                if (radius == 0)
                {
                    throw new ArgumentNullException("The radius cannot be zero");
                }
            }
        }

        public double CalculateArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return string.Format("{0} with perimeter {1:F2} and area {2:F2}", this.GetType().Name, this.CalculatePerimeter(),
                this.CalculateArea());
        }
    }
}

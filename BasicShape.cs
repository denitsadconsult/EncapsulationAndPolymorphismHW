using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndPolymorphismHW
{
    public abstract class BasicShape : IShape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        private double width;
        protected double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                this.width = value;

                if (width < 0)
                {
                    throw new ArgumentOutOfRangeException("The value must always be positive.");
                }

                if (width == 0)
                {
                    throw new ArgumentNullException("The value cannot be zero.");
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                this.height = value;

                if (height < 0)
                {
                    throw new ArgumentOutOfRangeException("The value must always be positive.");
                }

                if (height == 0)
                {
                    throw new ArgumentNullException("The value cannot be zero.");
                }
            }
        }
    }
}

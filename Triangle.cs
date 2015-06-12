using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EncapsulationAndPolymorphismHW
{
    public class Triangle : BasicShape
    {
        private double sideA;
        private double sideB;

        public class TriangleDimensionsException : Exception
        {
            public TriangleDimensionsException(string message) : base(message)
            {
            }
        }

        public Triangle(double width, double height, double sideA, double sideB)
            : base(width, height)
        {
            this.SideA = sideA;
            this.SideB = sideB;

            if (sideA + sideB < width || sideA + width < sideB || sideB + width < sideA)
            {
                throw new TriangleDimensionsException("Invalid triangle entered; a valid triangle is a triangle in which the sum of any two sides is greater than the value of the third side");
            }
        }

        public double SideA
        {
            get { return this.sideA; }
            set
            {
                this.sideA = value;
                
                if (sideA < 0)
                {
                    throw new ArgumentOutOfRangeException("The value for a triangle side must always be positive.");
                }

                if (sideA == 0)
                {
                    throw new ArgumentNullException("The value for a triangle side cannot be zero.");
                }
            }
        }

        public double SideB
        {
            get { return this.sideB; }
            set
            {
                this.sideB = value;

                if (sideB < 0)
                {
                    throw new ArgumentOutOfRangeException("The value for a triangle side must always be positive.");
                }

                if (sideB == 0)
                {
                    throw new ArgumentNullException("The value for a triangle side cannot be zero.");
                }
            }
        }

        public override double CalculateArea()
        {
            return (Height*Width)/2;
        }

        public override double CalculatePerimeter()
        {
            return Width + SideA + SideB;
        }

        public override string ToString()
        {
            return string.Format("{0} with perimeter {1:F2} and area {2:F2}", this.GetType().Name, this.CalculatePerimeter(),
                this.CalculateArea());
        }
    }
}

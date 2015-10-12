namespace Abstraction
{
    using System;
    using System.Text;

    public class Circle : Figure, IFigure
    {
        private double radius;

        public Circle(double radius)
            : base()
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Radius cannot be negative number or zero");
                }

                this.radius = value;
            } 
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine()
                .AppendFormat("My radius is {0:F2}.", this.Radius);

            return result.ToString();
        }
    }
}

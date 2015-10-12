

namespace _01_Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double side, double height)
            : base(side, height)
        {

        }

        public override double CalculateSurface()
        {
            double surface = (this.Height * this.Width) / 2;
            return surface;
        }
    }
}

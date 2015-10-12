namespace _01_Shapes
{
    public class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {

        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}

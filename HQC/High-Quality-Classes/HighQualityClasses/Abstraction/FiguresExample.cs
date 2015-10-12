namespace Abstraction
{
    using System;

    public class FiguresExample
    {
        public static void Main()
        {
            IFigure circle = new Circle(5);
            Console.WriteLine(circle.ToString());

            IFigure rect = new Rectangle(2, 3);
            Console.WriteLine(rect.ToString());
        }
    }
}

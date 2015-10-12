namespace _01_ClassSizeInCSharp
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive number");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive number");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure figure, double angleOfTheFigureToBeRotaed)
        {
            double cosinusWidth = Math.Abs(Math.Cos(angleOfTheFigureToBeRotaed)) * figure.Width;
            double sinusWidth = Math.Abs(Math.Sin(angleOfTheFigureToBeRotaed)) * figure.Width;
            double cosinusHeight = Math.Abs(Math.Cos(angleOfTheFigureToBeRotaed)) * figure.Height;
            double sinusHeight = Math.Abs(Math.Sin(angleOfTheFigureToBeRotaed)) * figure.Height;

            double rotatedFigureWidth = cosinusWidth + sinusHeight;
            double rotatedFigureHeight = sinusWidth + cosinusHeight;

            Figure rotatedFigure = new Figure(rotatedFigureWidth, rotatedFigureHeight);

            return rotatedFigure;
        }
    }
}

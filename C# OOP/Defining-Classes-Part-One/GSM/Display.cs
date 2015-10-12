namespace GSM
{
    using System;

    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size of display must be positive number");
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors must be bigger than 0");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Size: {0}, Number of colors: {1}", this.Size, this.NumberOfColors); 
        }

    }
}

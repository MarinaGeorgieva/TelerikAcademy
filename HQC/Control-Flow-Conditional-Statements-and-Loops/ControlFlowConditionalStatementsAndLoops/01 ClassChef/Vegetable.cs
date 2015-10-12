namespace _01_ClassChef
{
    using System;

    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsCooked = false;
            this.IsRotten = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        public bool IsRotten { get; set; }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }
    }
}

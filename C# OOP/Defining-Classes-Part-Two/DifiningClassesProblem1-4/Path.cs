namespace DifiningClassesProblem1_4
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        public void AddPoint(double x, double y, double z)
        {
            this.points.Add(new Point3D(x, y, z));
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }
    }
}

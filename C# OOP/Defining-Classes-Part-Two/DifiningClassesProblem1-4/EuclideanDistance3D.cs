namespace DifiningClassesProblem1_4
{
    using System;

    public static class EuclideanDistance3D
    {
        public static double Distance3D(Point3D first, Point3D second)
        {
            double diffX = second.X - first.X;
            double diffY = second.Y - first.Y;
            double diffZ = second.Z - first.Z;

            double result = Math.Sqrt((diffX * diffX) + (diffY * diffY) + (diffZ * diffZ));

            return result;
        }
    }
}

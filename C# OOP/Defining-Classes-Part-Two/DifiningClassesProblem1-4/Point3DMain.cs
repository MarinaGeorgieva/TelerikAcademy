/* Problem 1. Structure

Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.

Problem 2. Static read-only field

Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
Add a static property to return the point O.

Problem 3. Static class

Write a static class with a static method to calculate the distance between two points in the 3D space.

Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file. */

namespace DifiningClassesProblem1_4
{
    using System;

    class Point3DMain
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(3, 4, 0);
            Point3D secondPoint = new Point3D(6, 6, 6);
            Point3D thirdPoint = new Point3D(7.5, 2, 10.8);
            Point3D OPoint = Point3D.PointO;

            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
            Console.WriteLine(thirdPoint);
            Console.WriteLine(OPoint);

            double dist = EuclideanDistance3D.Distance3D(secondPoint, firstPoint);
            Console.WriteLine("\nDistance between {0} and {1} is {2}", secondPoint, firstPoint, dist);

            Path path = new Path();
            path.AddPoint(firstPoint);
            path.AddPoint(secondPoint);
            path.AddPoint(thirdPoint);
            path.AddPoint(OPoint);

            PathStorage.SavePath("..\\..\\savedPoints.txt", path);
            Path loadedPath = PathStorage.LoadPath("..\\..\\savedPoints.txt");

            Console.WriteLine("\nLoading points from file savedPoints.txt.... ");
            foreach (Point3D point in loadedPath.Points)
            {
                Console.WriteLine(point);
            }
        }
    }
}

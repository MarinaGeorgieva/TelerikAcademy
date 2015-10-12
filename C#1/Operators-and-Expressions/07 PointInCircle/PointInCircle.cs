// Problem 7. Point in a Circle

// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x coordinate of the point: ");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter y coordinate of the point: ");
        double yCoord = double.Parse(Console.ReadLine());

        bool isInside = ((xCoord - 0) * (xCoord - 0) + (yCoord - 0) * (yCoord - 0) <= 4);
        Console.WriteLine("The point (" + xCoord + ", " + yCoord + ") is inside the circle K({0, 0}, 2) ---> " + isInside);
    }
}



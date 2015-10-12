// Problem 10. Point Inside a Circle & Outside of a Rectangle

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x coordinate of the point: ");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter y coordinate of the point: ");
        double yCoord = double.Parse(Console.ReadLine());

        bool isInsideCircle = ((xCoord - 1) * (xCoord - 1) + (yCoord - 1) * (yCoord - 1)) <= 1.5 * 1.5;
        bool isOutsideRectangle = !((xCoord >= -1 && xCoord <= 5) && (yCoord >= -1 && yCoord <= 1));
        bool result = isInsideCircle && isOutsideRectangle;
        Console.WriteLine("The point (" + xCoord + ", " + yCoord +
            ") is inside the circle K({1, 1}, 1.5) and otside of the rectangle R(top = 1, left = -1, width = 6, height = 2) ---> " + result);
    }
}


// Problem 4. Rectangles

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("The perimeter of the rectangle is " + perimeter);
        Console.WriteLine("The area of the rectangle is " + area);
    }
}

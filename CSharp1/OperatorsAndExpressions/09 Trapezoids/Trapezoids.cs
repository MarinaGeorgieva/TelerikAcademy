// Problem 9. Trapezoids

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side a of the trapezoid: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side b of the trapezoid: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height h of the trapezoid: ");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2;
        Console.WriteLine("Trapezoid's area is " + area);
    }
}


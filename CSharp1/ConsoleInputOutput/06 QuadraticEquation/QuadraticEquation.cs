// Problem 6. Quadratic Equation

// Write a program that reads the coefficients a, b and c of a quadratic equation ax^2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        Console.WriteLine("Real roots of the quadratic equation {0}x^2 + {1}x + {2} are:", a, b, c);
        Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
    }
}


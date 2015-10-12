// Problem 4. Triangle surface

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

using System;

class TriangleSurface
{
    static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter ha: ");
        double ha = double.Parse(Console.ReadLine());
               
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Enter gamma: ");
        double gamma = double.Parse(Console.ReadLine());

        Console.WriteLine("Area = {0}", AreaWithAltitude(a, ha));
        Console.WriteLine("Area = {0}", AreaWithHeron(a, b, c));
        Console.WriteLine("Area = {0}", AreaWithAngle(a, b, gamma));
    }

    static double AreaWithAltitude(double a, double ha)
    {
        double area = a * ha / 2;
        return area;
    }

    static double AreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }

    static double AreaWithAngle(double a, double b, double gamma)
    {
        double area = a * b * Math.Sin(gamma) / 2;
        return area;
    }
}


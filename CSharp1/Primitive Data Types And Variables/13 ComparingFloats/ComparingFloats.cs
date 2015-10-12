// Problem 13.* Comparing Floats

// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first real number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second real number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double eps = 0.000001;
        bool isEqual;
        if (Math.Abs(a - b) < eps)
        {
            isEqual = true;
        }
        else
        {
            isEqual = false;
        }

        Console.WriteLine("The two real numbers are equal - " + isEqual);
    }
}


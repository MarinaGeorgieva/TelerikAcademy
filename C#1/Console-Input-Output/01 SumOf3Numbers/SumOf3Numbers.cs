// Problem 1. Sum of 3 Numbers

// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;
        Console.WriteLine("Sum: {0} + {1} + {2} = {3}", a, b, c, sum);
    }
}


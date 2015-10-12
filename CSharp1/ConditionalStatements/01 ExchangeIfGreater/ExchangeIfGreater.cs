// Problem 1. Exchange If Greater

// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
// As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("Result: {0} {1}", a, b);
    }
}


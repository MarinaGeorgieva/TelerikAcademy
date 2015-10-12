// Problem 6. The Biggest of Five Numbers

// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());

        double biggest = a;

        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        if (d > biggest)
        {
            biggest = d;
        }
        if (e > biggest)
        {
            biggest = e;
        }

        Console.WriteLine("The biggest of the numbers {0}, {1}, {2}, {3}, {4} is {5}", a, b, c, d, e, biggest);
    }
}


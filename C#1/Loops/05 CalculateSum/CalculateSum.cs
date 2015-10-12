// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.

using System;

class CalculateSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number x: ");
        int x = int.Parse(Console.ReadLine());

        int numerator = 1;
        int denominator = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            numerator *= i;
            denominator *= x;
            sum += (double) numerator / denominator;
        }

        Console.WriteLine("Sum is {0:F5}", sum);
    }
}


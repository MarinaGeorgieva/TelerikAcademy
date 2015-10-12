// Problem 17.* Calculate GCD

// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.

using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an integer number b: ");
        int b = int.Parse(Console.ReadLine());

        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        int gcd = a;

        Console.WriteLine("The greatest common divisor of the numbers is {0}", gcd);
    }
}


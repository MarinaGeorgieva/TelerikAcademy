// Problem 5. The Biggest of 3 Numbers

// Write a program that finds the biggest of three numbers.

using System;

class BiggestOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        double biggest = a;

        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }

        Console.WriteLine("The biggest of the numbers {0}, {1}, {2} is {3}", a, b, c, biggest);
    }
}


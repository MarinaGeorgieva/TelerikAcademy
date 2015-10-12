// Problem 4. Number Comparer

// Write a program that gets two numbers from the console and prints the greater of them.

using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        double greater = (a >= b) ? a : b;
        Console.WriteLine("The greater number from {0} and {1} is {2}", a, b, greater);
    }
}


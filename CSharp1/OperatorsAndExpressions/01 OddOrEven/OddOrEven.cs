// Problem 1. Odd or Even Integers

// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        string result = (number % 2 == 0) ? "even" : "odd";
        Console.WriteLine("The number {0} is {1}!", number, result);
    }
}


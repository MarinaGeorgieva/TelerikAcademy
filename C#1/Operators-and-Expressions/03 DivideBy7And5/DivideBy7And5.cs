// Problem 3. Divide by 7 and 5

// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivisible = (number % 5 == 0 && number % 7 == 0);
        Console.WriteLine("The number {0} is divisible by 7 and 5 at the same time - {1}", number, isDivisible);
    }
}


// Problem 5. Third Digit is 7?

// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isSeven = (number / 100 % 10 == 7);
        Console.WriteLine("The third digit from right ro left of the number {0} is 7 - {1}", number, isSeven);
    }
}


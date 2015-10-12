// Problem 4. Multiplication Sign

// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        char sign;

        if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0))
        {
            sign = '+';
        }
        else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
        {
            sign = '-';
        }
        else
        {
            sign = '0';
        }
        Console.WriteLine("The sign of the product of the numbers {0}, {1}, {2} is {3}", a, b, c, sign);
    }
}


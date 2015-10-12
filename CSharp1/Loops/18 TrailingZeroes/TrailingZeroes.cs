// Problem 18.* Trailing Zeroes in N!

// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.

using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factoriel = 1;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
        }

        int countZeroes = 0;
        BigInteger digit = factoriel % 10;

        while (digit == 0)
        {         
            countZeroes++;
            factoriel /=  10;
            digit = factoriel % 10;
        }

        Console.WriteLine("{0}! has {1} zeroes", n, countZeroes);
    }
}


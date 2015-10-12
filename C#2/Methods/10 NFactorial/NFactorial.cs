// Problem 10. N Factorial

// Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class NFactorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("Factorials of numbers in range [1...100]");
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, Factorial(i));
        }
    }

    static BigInteger Factorial(int number)
    {
        BigInteger fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact *= i;
        }

        return fact;
    }
}


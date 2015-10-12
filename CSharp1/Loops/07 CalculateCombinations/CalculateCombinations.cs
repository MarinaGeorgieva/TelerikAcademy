// Problem 7. Calculate N! / (K! * (N-K)!)

// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        double n = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter k: ");
        double k = double.Parse(Console.ReadLine());

        BigInteger result = 1;

        if (n < 100 && (k > 1 && k < n))
        {
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                if (i <= k)
                {
                    result /= i;
                }
            }

            for (int j = 1; j <= n - k; j++)
            {
                result /= j;
            }

                Console.WriteLine("Result ---> {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}


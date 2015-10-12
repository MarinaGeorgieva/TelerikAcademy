// Problem 8. Catalan Numbers

// Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger catalan = 1;

        if (n >= 0 && n <= 100) 
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                catalan *= i;

                if (i <= n)
                {
                    catalan /= i;
                }
            }

            for (int j = 1; j <= n + 1; j++)
            {
                catalan /= j;
            }

                Console.WriteLine("The {0}-th Catalan number is {1}", n, catalan);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}


// Problem 6. Calculate N! / K!

// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).

using System;

class CalculateFactorielDivision
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int result = 1;
        
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

            Console.WriteLine("Result ---> {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}


// Problem 10. Fibonacci Numbers

// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence. 

using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number n:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("The first {0} members of the Fibonacci sequence: ", n);
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                numbers[i] = 0;
            }
            else if (i == 1)
            {
                numbers[i] = 1;
            }
            else
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }
            Console.Write("{0}, ", numbers[i]);
        }
        Console.WriteLine();
    }
}


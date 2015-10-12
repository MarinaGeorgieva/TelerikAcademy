// Problem 11. Random Numbers in Given Range

// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInRange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter min: ");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        Random random = new Random();

        Console.WriteLine("Random numbers in range [{0},{1}]", min, max);
        for (int i = 0; i < n; i++)
        {
            int number = random.Next(min, max + 1);
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}


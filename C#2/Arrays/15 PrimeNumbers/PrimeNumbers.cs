// Problem 15. Prime numbers

// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter positive number bigger than 1: ");
        int number = int.Parse(Console.ReadLine());

        bool[] array = new bool[number - 1];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = true;
        }

        for (int i = 2; i < Math.Sqrt(number) + 1; i++)
        {
            if (array[i - 2] == true)
            {
                for (int p = i * i; p <= number; p += i)
                {
                    array[p - 2] = false;
                }
            }
        }

        Console.WriteLine("Prime numbers between 1 and {0}: ", number);
        Console.Write(1 + " ");
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] == true)
            {
                Console.Write((index + 2) + " ");
            }
        }
        Console.WriteLine();   
    }
}


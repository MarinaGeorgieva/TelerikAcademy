// Problem 6. Maximal K sum

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;
using System.Collections;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            array[index] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int sum = 0;

        for (int index = array.Length - 1; index >= array.Length - k; index--)
        {
            sum += array[index];
        }

        Console.WriteLine("Maximal sum of {0} elements is {1}", k, sum);
    }
}


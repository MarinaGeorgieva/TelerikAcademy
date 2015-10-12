// Problem 14. Integer calculations

// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerCalculations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Minimum element of array is {0}", Min(1, 3, 4, 2, 7, 13, 17, 10, 5, 8, 21, 6));
        Console.WriteLine("Maximum element of array is {0}", Max(1, 3, 4, 2, 7, 13, 17, 10, 5, 8, 21, 6));
        Console.WriteLine("Sum of array is {0}", Sum(1, 3, 4, 2, 7, 13, 17, 10, 5, 8, 21, 6));
        Console.WriteLine("Product of array is {0}", Product(1, 3, 4, 2, 7, 13, 17, 10, 5, 8, 21, 6));
        Console.WriteLine("Average of array is {0}", Average(1, 3, 4, 2, 7, 13, 17, 10, 5, 8, 21, 6));
    }

    static int Min(params int[] numbers) 
    {
        int min = int.MaxValue;

        for (int index = 0; index < numbers.Length; index++)
        {
            if (numbers[index] < min)
            {
                min = numbers[index];
            }
        }

        return min;
    }

    static int Max(params int[] numbers)
    {
        int max = int.MinValue;

        for (int index = 0; index < numbers.Length; index++)
        {
            if (numbers[index] > max)
            {
                max = numbers[index];
            }
        }

        return max;
    }

    static int Sum(params int[] numbers)
    {
        int sum = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            sum += numbers[index];
        }

        return sum;
    }

    static int Product(params int[] numbers)
    {
        int prod = 1;

        for (int index = 0; index < numbers.Length; index++)
        {
            prod *= numbers[index];
        }

        return prod;
    }

    static double Average(params int[] numbers)
    {
        int sum = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            sum += numbers[index];
        }

        return (double)sum / numbers.Length;
    }
}


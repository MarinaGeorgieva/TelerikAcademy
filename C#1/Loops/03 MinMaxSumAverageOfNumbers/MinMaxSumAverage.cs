// Problem 3. Min, Max, Sum and Average of N Numbers

// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
// the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;

class MinMaxSumAverage
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            sum += number;

            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }

        double average = (double) sum / n;

        Console.WriteLine("Sum of the numbers is {0}", sum);
        Console.WriteLine("Max of the numbers is {0}", max);
        Console.WriteLine("Min of the numbers is {0}", min);
        Console.WriteLine("Average of the numbes is {0:F2}", average);
    }
}


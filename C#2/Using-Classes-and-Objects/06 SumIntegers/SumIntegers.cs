// Problem 6. Sum integers

// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

using System;
using System.Linq;

class SumIntegers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sequence of positive integers in a string, separated by spaces: ");
        string numbers = Console.ReadLine();

        Console.WriteLine("Sum of numbers is {0}", CalculateSum(numbers));
    }

    static int CalculateSum(string numbers)
    {
        int[] numbersArray = numbers.Split(' ').Select(int.Parse).ToArray();
        return numbersArray.Sum();
    }
}


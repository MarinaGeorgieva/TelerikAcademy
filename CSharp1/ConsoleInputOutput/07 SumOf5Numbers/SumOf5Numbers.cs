// Problem 7. Sum of 5 Numbers

// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 numbers in a single line, separated by a space: ");
        string[] numbers = Console.ReadLine().Split(' ');
        double firstNumber = double.Parse(numbers[0]);
        double secondNumber = double.Parse(numbers[1]);
        double thirdNumber = double.Parse(numbers[2]);
        double fourthNumber = double.Parse(numbers[3]);
        double fifthNumber = double.Parse(numbers[4]);

        double sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
        Console.WriteLine("Sum of the numbers is {0}", sum);
    }
}


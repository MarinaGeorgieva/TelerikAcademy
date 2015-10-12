// Problem 9. Sum of n Numbers

// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 

using System;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers: ", n);
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {            
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum of the {0} entered numbers is {1}", n, sum);
    }
}


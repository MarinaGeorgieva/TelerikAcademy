// Problem 13. Solve tasks

// Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SolveTasks
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Reverse digits of a number");
        Console.WriteLine("2. Calculate average of a sequence of integers");
        Console.WriteLine("3. Solve linear equation a * x + b = 0");

        byte choice;

        do
        {
            Console.Write("\nEnter your choice: ");
            choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: ReverseDigits();
                    break;
                case 2: CalculateAverage();
                    break;
                case 3: SolveEquation();
                    break;
                default: Console.WriteLine("Your choice was invalid...");
                    choice = 0;
                    break;
            }
        } while (choice == 0);
    }

    static void ReverseDigits()
    {
        double number;

        do
        {
            Console.Write("Enter positive number: ");
            number = double.Parse(Console.ReadLine());
        } while (number < 0);

        string numberStr = number.ToString();
        string result = "";

        for (int i = 0; i < numberStr.Length; i++)
        {
            result += numberStr[numberStr.Length - 1 - i];
        }

        Console.WriteLine("Result: {0} ---> {1}", number, result);
    }

    static void CalculateAverage()
    {
        int n;

        do
        {
            Console.Write("Enter length of array: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);

        int[] numbers = new int[n];
        int sum = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write("Enter {0} element of array: ", index + 1);
            numbers[index] = int.Parse(Console.ReadLine());
            sum += numbers[index];
        }

        Console.WriteLine("Average of the array is {0}", (double)sum / n);
    }

    static void SolveEquation()
    {
        double a;

        do
        {
            Console.Write("Enter a: ");
            a = double.Parse(Console.ReadLine());
        } while (a == 0);

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        double x = -b / a;

        Console.WriteLine("Result: x = {0}", x);
    }
}


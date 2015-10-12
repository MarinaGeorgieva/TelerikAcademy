// Problem 1. Square root

// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a positive integer number: ");
            int number = int.Parse(Console.ReadLine());

            double root = Sqrt(number);
            Console.WriteLine(root);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }            
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }

    static double Sqrt(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        return Math.Sqrt(number);
    }
}


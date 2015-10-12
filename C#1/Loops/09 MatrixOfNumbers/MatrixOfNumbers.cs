// Problem 9. Matrix of Numbers

// Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. 
// Examples:

// n = 2   matrix      n = 3   matrix      n = 4   matrix
//         1 2                 1 2 3               1 2 3 4
//         2 3                 2 3 4               2 3 4 5
//                             3 4 5               3 4 5 6
//                                                 4 5 6 7

using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer number n: ");
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            int start = row;

            for (int col = 0; col < n; col++)
            {
                start++;
                Console.Write(start + " ");
            }
            Console.WriteLine();
        }
    }
}


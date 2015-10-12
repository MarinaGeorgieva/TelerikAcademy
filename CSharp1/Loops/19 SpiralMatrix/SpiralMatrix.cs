// Problem 19.** Spiral Matrix

// Write a program that reads from the console a positive integer number n (1 = n = 20) 
// and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
// Examples:

// n = 2   matrix      n = 3   matrix      n = 4   matrix
//         1 2                 1 2 3               1  2  3  4
//         4 3                 8 9 4               12 13 14 5
//                             7 6 5               11 16 15 6
//                                                 10 9  8  7

using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int counter = 1;
        int start = 0;

        while (counter <= n * n)
        {
            for (int col = start; col < n - start; col++)
            {
                matrix[start, col] = counter;
                counter++;
            }

            for (int row = 1 + start; row < n - start; row++)
            {
                matrix[row, n - 1 - start] = counter;
                counter++;
            }

            for (int col = n - 2 - start; col >= 0 + start; col--)
            {
                matrix[n - 1 - start, col] = counter;
                counter++;
            }

            for (int row = n - 2 - start; row >= 1 + start; row--)
            {
                matrix[row, start] = counter;
                counter++;
            }
            start++;
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
        
    }
}


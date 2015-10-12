// Problem 1. Fill the matrix

// Write a program that fills and prints a matrix of size (n, n) as shown below:
// Example for n=4:

//      1	12	11	10
//      2	13	16	9
//      3	14	15	8
//      4	5	6	7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int start = 0;
        int number = 1;

        while (number <= n * n)
        {           
            for (int row = start; row < n - start; row++)
            {
                matrix[row, start] = number;
                number++;
            }

            for (int col = start + 1; col < n - start; col++)
            {
                matrix[n - start - 1, col] = number;
                number++;
            }

            for (int row = n - start - 2; row >= 0 + start; row--)
            {
                matrix[row, n - start - 1] = number;
                number++;
            }

            for (int col = n - start - 2; col >= 1 + start; col--)
            {
                matrix[start, col] = number;
                number++;
            }

            start++;
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}


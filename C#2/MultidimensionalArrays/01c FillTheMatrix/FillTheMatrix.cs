// Problem 1. Fill the matrix

// Write a program that fills and prints a matrix of size (n, n) as shown below:
// Example for n=4:

//      7	11	14	16
//      4	8	12	15
//      2	5	9	13
//      1	3	6	10

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

        int start = 1;
        int diff = 2;
        int count = 2;

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col <= row; col++)
            {
                if (col == 0)
                {
                    matrix[row, col] = start;
                }
                else
                {
                    matrix[row, col] = start + diff;
                    start += diff;
                    diff++;
                }

            }

            count++;
            diff = count;
            start = matrix[n - 1, n - 1 - row] + 1;
        }

        start = n * n;
        diff = 2;
        count = 2;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = matrix.GetLength(0) - 1; col >= row + 1; col--)
            {
                if (col == matrix.GetLength(0) - 1)
                {
                    matrix[row, col] = start;
                }
                else
                {
                    matrix[row, col] = start - diff;
                    start -= diff;
                    diff++;
                }
            }

            count++;
            diff = count;
            start = matrix[row, n - 2] + 1;
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


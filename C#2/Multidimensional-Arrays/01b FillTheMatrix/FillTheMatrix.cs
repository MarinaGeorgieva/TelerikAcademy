// Problem 1. Fill the matrix

// Write a program that fills and prints a matrix of size (n, n) as shown below:
// Example for n=4:

//      1	8	9	16
//      2	7	10	15
//      3	6	11	14
//      4	5	12	13

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

        int diff = 0;
        int start = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            start = row;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = start + 1;
                    start = start + 1;
                }
                else
                {
                    matrix[row, col] = start + 2 * n - 1 - diff;
                    start = start + 2 * n - 1;
                }
            }

            diff += 2;
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


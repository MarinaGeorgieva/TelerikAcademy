// Problem 5. Maximal area sum

// Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.

using System;
using System.IO;

class MaximalAreaSum
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string curLine = reader.ReadLine();

            int size = int.Parse(curLine);
            int[,] matrix = new int[size, size];
            int row = 0;

            while (curLine != null)
            {
                curLine = reader.ReadLine();

                if (curLine != null)
                {
                    string[] numbers = curLine.Split(' ');
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = int.Parse(numbers[col]);
                    }
                    row++;
                }
            }

            int maximalSum = GetMaximalSum(matrix);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(maximalSum);
            }
        }


    }

    private static int GetMaximalSum(int[,] matrix)
    {
        int currentSum = 0;
        int maxSum = 0;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int row = i; row < i + 2; row++)
                {
                    for (int col = j; col < j + 2; col++)
                    {
                        currentSum += matrix[row, col];
                    }
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                currentSum = 0;
            }
        }

        return maxSum;
    }
}


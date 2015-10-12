// Problem 7.* Largest area in matrix

// Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestAreaInMatrix
{
    const int arrayRow = 5;
    const int arrayCol = 6;
    const int countArrayLength = 10;

    static void Main(string[] args)
    {
        int[,] matrix = {
                        {1,3,2,2,5,3},
                        {3,3,3,2,4,4},
                        {4,3,1,2,3,3},
                        {4,3,1,3,3,1},
                        {4,3,3,3,1,1}};

        int[] countArray = new int[countArrayLength];

        for (int row = 0; row < arrayRow; ++row)
        {
            for (int col = 0; col < arrayCol; ++col)
            {
                countArray[matrix[row, col]]++;
                if (!ExistingNeighbour(matrix, row, col, countArray))
                {
                    countArray[matrix[row, col]]--;
                }
            }
        }

        int maxElem = countArray[0];
        for (int index = 0; index < countArrayLength; index++)
        {
            if (maxElem < countArray[index])
            {
                maxElem = countArray[index];
            }
        }

        Console.WriteLine(maxElem);
    }

    public static bool ExistingNeighbour(int[,] matrix, int row, int col, int[] countArray)
    {
        bool isExisting = false;
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if ((j + col < arrayCol) && (i + row < arrayRow) && i < 2 && j < 2 && i > 0 && j > 0)
                {

                    if (matrix[row + i, col + j] == matrix[row, col])
                    {
                        isExisting = true;
                    }
                }

                if (row > 0 && col > 0 && i == 2 && j == 2)
                {
                    if (matrix[row - 1, col - 1] == matrix[row, col])
                    {
                        isExisting = true;
                    }
                }

                if (row > 0 && col + j < arrayCol && i == 2 && j < 2)
                {
                    if (matrix[row - 1, col + j] == matrix[row, col])
                    {
                        isExisting = true;
                    }
                }

                if (i < 2 && j == 2 && col > 0 && row + i < arrayRow)
                {
                    if (matrix[row + i, col - 1] == matrix[row, col])
                    {
                        isExisting = true;
                    }
                }
            }
        }
        return isExisting;
    }
}


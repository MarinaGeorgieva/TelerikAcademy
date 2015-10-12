// Problem 2. Maximal sum

// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        int[,] array = new int[n, m];

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.WriteLine("Enter {0}, {1} element: ", row + 1, col + 1);
                array[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int sum = 0;
        for (int row = 0; row < array.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < array.GetLength(1) - 2; col++)
            {
                if (sum < SumOfSub(array, row, col))
                {
                    sum = SumOfSub(array, row, col);
                }
            }
        }

        Console.WriteLine("Sum is {0}", sum);
    }

    public static int SumOfSub(int[,] array, int row, int col)
    {
        int sum = 0;

        for (int index = row; index < row + 3; ++index)
        {

            for (int elem = col; elem < col + 3; ++elem)
            {

                sum += array[index, elem];
            }
        }

        return sum;
    }
}


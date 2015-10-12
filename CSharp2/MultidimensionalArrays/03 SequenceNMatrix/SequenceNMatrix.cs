// Problem 3. Sequence n matrix

// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour 
// elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceNMatrix
{
    static void Main(string[] args)
    {
        string[,] matrix = { 
                           {"ha", "fifi", "ho", "hi"},
                           {"fo", "ha", "hi", "xx"},
                           {"xxx", "ho", "ha", "xx"}};

        int currentSequence = 1;
        int maxSequence = 1;
        string element = "";

        // horizontally
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSequence++;
                }
                
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    element = matrix[row, col];
                }                
            }
            currentSequence = 1;
        }

        //vertically
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSequence++;
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    element = matrix[row, col];
                }
            }
            currentSequence = 1;
        }

        // diagonally from left to right
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                currentSequence++;
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
                element = matrix[row, col];
            }
        }
        currentSequence = 1;

        // diagonally from right to left
        for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
        {
            if (matrix[row, col] == matrix[row + 1, col - 1])
            {
                currentSequence++;
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
                element = matrix[row, col];
            }
        }
        currentSequence = 1; 

        Console.WriteLine("Element {0} repeats {1} times ", element, maxSequence);
    }
}

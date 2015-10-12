// Problem 5. Larger than neighbours

// Write a method that checks if the element at given position in given array of integers 
// is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] array = { 3, 1, 5, 6, 8, 1, 10, 23, 5, 7, 12};

        Console.WriteLine(isLargerThanNeighbours(array, 4));
        Console.WriteLine(isLargerThanNeighbours(array, 7));
        Console.WriteLine(isLargerThanNeighbours(array, 9));
    }

    static bool isLargerThanNeighbours(int[] array, int position)
    {
        if (position > 0 && position < array.Length - 2)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
        }

        return false;
    }
}


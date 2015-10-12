// Problem 6. First larger than neighbours

// Write a method that returns the index of the first element in array that is larger than its neighbours, 
// or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] array = { 3, 1, 5, 6, 8, 1, 10, 23, 5, 7, 12 };
        Console.WriteLine(GetIndex(array));

        int[] array2 = { 1, 2, 3, 4, 5, 7, 8, 15};
        Console.WriteLine(GetIndex(array2));
    }

    static int GetIndex(int[] array)
    {        
        for (int index = 1; index < array.Length - 1; index++)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return index;
            }
        }

        return -1;
    }
}


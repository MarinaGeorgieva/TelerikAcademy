// Problem 9. Sorting array

// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingArray
{
    static void Main(string[] args)
    {
        int[] array = { 2, 3, 1, 5, 13, 8, 7};

        Console.WriteLine("Max element in the array is {0}", MaxElement(array, 0));

        SortDescending(array);

        Console.WriteLine("Array sorted in descending order: ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();

        SortAscending(array);

        Console.WriteLine("Array sorted in ascending order: ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();
    }

    static int MaxElement(int[] array, int index)
    {
        int max = int.MinValue;

        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            } 
        }

        return max;
    }

    static int MaxElementIndex(int[] array, int index)
    {
        int max = int.MinValue;
        int maxIndex = 0;

        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    static void SortDescending(int[] array)
    {        
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int maxIndex = MaxElementIndex(array, array.Length - 1 - i);
            int temp = array[array.Length - 1 - i];           
            array[array.Length - 1 - i] = MaxElement(array, array.Length - 1 - i);
            array[maxIndex] = temp;
        }
    }

    static void SortAscending(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int maxIndex = MaxElementIndex(array, array.Length - 1 - i);
            int temp = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = MaxElement(array, array.Length - 1 - i);
            array[maxIndex] = temp;
        }

        int[] sorted = array.Clone() as int[];

        for (int i = 0; i < sorted.Length; i++)
        {
            array[i] = sorted[sorted.Length - 1 - i];
        }
    }
}


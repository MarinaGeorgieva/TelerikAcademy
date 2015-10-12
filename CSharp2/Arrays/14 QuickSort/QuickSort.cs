// Problem 14. Quick sort

// Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

class QuickSort
{
    static void Main(string[] args)
    {
        string[] array = { "o", "f", "l", "a", "e", "m", "t", "z", "b", "q", "k"};

        Console.WriteLine("Unsorted array: ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();

        Quicksort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted array: ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();
    }

    public static int Partition(string[] array, int left, int right)
    {
        string pivot = array[right];
        int start = left - 1;

        for (int index = left; index <= right; index++)
        {
            if (array[index].CompareTo(pivot) <= 0)
            {
                start++;
                string temp = array[index];
                array[index] = array[start];
                array[start] = temp;
            }
        }
        return start;
    }

    public static void Quicksort(string[] array, int left, int right) 
    {
        if (left >= right)
        {
            return;
        }

        int start = Partition(array, left, right);

        Quicksort(array, left, start -1);
        Quicksort(array, start + 1, right);
       
    }
}


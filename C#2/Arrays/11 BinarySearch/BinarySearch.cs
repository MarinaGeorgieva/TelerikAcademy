// Problem 11. Binary search

// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            array[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element to search for: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);
        Console.WriteLine(Search(array, k));
    }

    public static int Search(int[] array, int key)
    {
        int min = 0;
        int max = array.Length - 1;
        int mid = 0;

        while (min <= max)
        {
            mid = min + (max - min) / 2;

            if (array[mid] == key)
            {
                return mid;
            }
            else if (array[mid] > key)
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return -1;
    }
}


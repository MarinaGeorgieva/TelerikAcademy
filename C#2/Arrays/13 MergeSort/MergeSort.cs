// Problem 13.* Merge sort

// Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
{
    static void Main(string[] args)
    {
       int[] array = {1,13,52,7,5,25,6,88,1,2,14};

       Console.WriteLine("Unsorted array: ");
       for (int index = 0; index < array.Length; index++)
       {
           Console.Write(array[index] + " ");
       }
       Console.WriteLine();

       Mergesort(array, 0, array.Length - 1);

       Console.WriteLine("Sorted array: ");
       for(int index = 0; index < array.Length; index ++)
       {
           Console.Write(array[index] + " ");
       }

       Console.WriteLine();

    }

    public static void MergeArray(int[] a, int[] b, int[] c)
    {

        int aIndex = 0;
        int bIndex = 0;
        int cIndex = 0;
        while (aIndex < a.Length && bIndex < b.Length)
        {

            if (a[aIndex] < b[bIndex])
            {
                c[cIndex] = a[aIndex];
                aIndex++;
            }

            else
            {
                c[cIndex] = b[bIndex];
                bIndex++;
            }
            cIndex++;
        }

        if (aIndex == a.Length)
        {
            for (; bIndex < b.Length; bIndex++)
            {
                c[cIndex] = b[bIndex];
                cIndex++;
            }
        }

        else
        {
            for (; aIndex < a.Length; aIndex++)
            {
                c[cIndex] = a[aIndex];
                cIndex++;
            }
        }
    }

    public static void Mergesort(int[] array, int left, int right)
    {

        if (left == right)
        {
            return;
        }
        int middle = (left + right) / 2;

        Mergesort(array, left, middle);
        Mergesort(array, middle + 1, right);

        int[] leftArray = new int[middle - left + 1];
        int[] rightArray = new int[right - middle];
        int[] resultArray = new int[right - left + 1];

        for (int index = left; index <= middle; index++)
        {
            leftArray[index - left] = array[index];
        }

        for (int index = middle + 1; index <= right; index++)
        {
            rightArray[index - middle - 1] = array[index];
        }

        MergeArray(leftArray, rightArray, resultArray);

        for (int index = left; index <= right; index++)
        {
            array[index] = resultArray[index - left];
        }
    }
}


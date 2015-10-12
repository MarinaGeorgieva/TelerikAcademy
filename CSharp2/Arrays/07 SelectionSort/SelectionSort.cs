// Problem 7. Selection sort

// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
// move it at the second position, etc.

using System;

class SelectionSort
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

        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            if (min != i)
            {
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + " ");
        }

        Console.WriteLine();
    }
}


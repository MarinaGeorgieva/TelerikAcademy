// Problem 4. Binary search

// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine("Enter number {0}: ", index + 1);
            array[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);

        int number = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= k)
            {
                number = array[i];
            } 
        }

        Array.BinarySearch(array, number);

        if (array[0] > k)
        {
            Console.WriteLine("Can't find number...");
        }
        else
        {
            Console.WriteLine("The largest number <= k is {0}", number);
        }
        
    }
}


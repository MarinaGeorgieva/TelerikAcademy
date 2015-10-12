// Problem 17.* Subset K with sum S

// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
// Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetKWithSumS
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            array[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter s: ");
        int s = int.Parse(Console.ReadLine());

        int start = 0;
        int end = 0;
        bool exists = false;

        for (int i = 0; i < array.Length - k + 1; i++)
        {
            int sum = array[i];

            for (int j = i + 1; j < k + i; j++)
            {
                sum += array[j];
            }

            if (sum == s)
            {
                exists = true;
                start = i;
                end = k + i - 1;
            }
        }

        if (exists)
        {
            Console.WriteLine("Subset of {0} elements with sum {1}: ", k, s);
            for (int index = start; index < end + 1; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Subset doesn't exist...");
        }
    }
}


// Problem 5. Sort by string length

// You are given an array of strings. Write a method that sorts the array by the length of its elements 
// (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortByStringLength
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];

        for (int index = 0; index < array.Length; ++index)
        {
            Console.Write("Enter {0} element: ", index + 1);
            array[index] = Console.ReadLine();
        }

        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

        Console.WriteLine("Sorted array: ");
        foreach (string str in array)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }    
}


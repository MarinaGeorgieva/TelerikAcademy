﻿// Problem 1. Allocate array

// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main(string[] args)
    {
        int[] myArray = new int[20];

        for (int index = 0; index < myArray.Length; index++)
        {
            myArray[index] = index * 5;
            Console.Write(myArray[index] + " ");
        }

        Console.WriteLine();
    }
}


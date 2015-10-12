// Problem 2. Compare arrays

// Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the arrays: ");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];

        for (int index = 0; index < firstArray.Length; index++) 
        {
            Console.Write("Enter element {0}: ", index + 1);
            firstArray[index] = int.Parse(Console.ReadLine());
        }

        int[] secondArray = new int[n];

        for (int index = 0; index < secondArray.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            secondArray[index] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
       
        for (int index = 0; index < secondArray.Length; index++)
        {
            if (firstArray[index] == secondArray[index])
            {
                counter++;
            }
        }

        if (counter == n)
        {
            Console.WriteLine("The two arrays are equal!");
        }
        else
        {
            Console.WriteLine("The two arrays are not equal!");
        }
    }
}


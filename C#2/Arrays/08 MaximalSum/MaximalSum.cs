// Problem 8. Maximal sum

// Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the array: ");
        int length = int.Parse(Console.ReadLine());

        int[] myArray = new int[length];

        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            myArray[index] = int.Parse(Console.ReadLine());
        }
                
        int maxSum = int.MinValue;
        int currentSum = 0;
        int start = 0;
        int maxStart = 0;
        int end = 0;

        for (int index = 0; index < myArray.Length; index++)
        {
            currentSum += myArray[index];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxStart = start;
                end = index;
            }

            if (currentSum <= 0)
            {
                currentSum = 0;
                start = index;
            }
        }        

        Console.Write("Maximal sequence of increasing elements is: ");

        for (int index = maxStart + 1; index < end + 1; index++)
        {
            Console.Write(myArray[index] + " ");
        }
        Console.WriteLine();
    }
}


// Problem 5. Maximal increasing sequence

// Write a program that finds the maximal increasing sequence in an array.

using System;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];

        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            myArray[index] = int.Parse(Console.ReadLine());
        }

        int counter = 1;
        int max = 0;
        int end = 0;

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] < myArray[index + 1])
            {
                counter++;
            }
            else
            {
                if (counter > max)
                {
                    max = counter;
                    end = index;
                }
                counter = 1;
            }
        }

        if (counter > max)
        {
            max = counter;
            end = myArray.Length - 1;
        }

        Console.Write("Maximal sequence of increasing elements is: ");

        for (int index = end - max + 1; index < end + 1; index++)
        {
            Console.Write(myArray[index] + " ");
        }
        Console.WriteLine();
    }
}


// Problem 4. Maximal sequence

// Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
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
        int element = 0;

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] == myArray[index + 1])
            {
                counter++;
            }
            else
            {
                if (counter > max)
                {
                    max = counter;
                    element = myArray[index];
                }
                counter = 1;
            }
        }

        if (counter > max)
        {
            max = counter;
            element = myArray[myArray.Length - 1];
        }

        Console.Write("Maximal sequence of equal elements is: ");

        for (int i = 0; i < max; i++)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}


// Problem 9. Frequent number

// Write a program that finds the most frequent number in an array.

using System;

class FrequentNumber
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

        int counter = 0;
        int max = 0;
        int element = 0;
                
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            int currentNumber = myArray[i];

            for (int j = i; j < myArray.Length; j++)
            {
                if (myArray[j] == currentNumber)
                {
                    counter++;
                }
            }

            if (counter > max)
            {
                max = counter;
                element = myArray[i];
            }
            counter = 0;
        }

        Console.WriteLine("Most frequent number in the array is {0} ({1} times)", element, max);
    }
}


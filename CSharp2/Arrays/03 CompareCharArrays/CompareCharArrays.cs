// Problem 3. Compare char arrays

// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the arrays: ");
        int n = int.Parse(Console.ReadLine());

        char[] firstArray = new char[n];

        for (int index = 0; index < firstArray.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            firstArray[index] = char.Parse(Console.ReadLine());
        }

        char[] secondArray = new char[n];

        for (int index = 0; index < secondArray.Length; index++)
        {
            Console.Write("Enter element {0}: ", index + 1);
            secondArray[index] = char.Parse(Console.ReadLine());
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


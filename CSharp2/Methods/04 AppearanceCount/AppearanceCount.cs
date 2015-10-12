// Problem 4. Appearance count

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppearanceCount
{
    static void Main(string[] args)
    {
        int[] array = { 1, 3, 4, 5, 2, 1, 7, 5, 5, 8, 3, 5, 13, 28, 5, 1, 16, 10, 7, 7, 7, 7, 7, 7, 7};

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} appears {1} times in the array", number, CountAppearance(number, array));
    }

    static int CountAppearance(int number, int[] array)
    {
        int counter = 0;

        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] == number)
            {
                counter++;
            }
        }

        return counter;
    }
}


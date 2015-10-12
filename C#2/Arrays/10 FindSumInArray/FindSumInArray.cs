// Problem 10. Find sum in array

// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
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

        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());

        int sum = 0;
        int count = 0;
        int len = 0;
        int end = 0;

        for (int index = 0; index < array.Length; index++)
        {
            sum += array[index];
            count++;
            
            if (sum == s)
            {
                len = count;
                end = index;
            }

            if (sum > s)
            {
                sum = array[index];
                count = 1;
            }
        }

        if (len > 0)
        {
            Console.Write("Sequence with sum {0}: ", s);
            for (int index = end - len + 1; index < end + 1; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There isn't a sequence with sum {0} in the array...", s);
        }        
    }
}


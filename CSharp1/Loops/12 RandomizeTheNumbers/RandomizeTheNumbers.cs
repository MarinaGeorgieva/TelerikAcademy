// Problem 12.* Randomize the Numbers 1…N

// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections;

class RandomizeTheNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number n: ");
        int n = int.Parse(Console.ReadLine());

        ArrayList numbersList = new ArrayList();
        Random random = new Random();

        while (numbersList.Count != n)
        {
            int number = random.Next(1, n + 1);
            if (!numbersList.Contains(number)) 
            {
                numbersList.Add(number);
            }     
        }

        foreach (int number in numbersList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

    }
}


// Problem 1. Leap year

// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.

using System;

class LeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year is leap");
        }
        else
        {
            Console.WriteLine("The year isn't leap");
        }

    }

}


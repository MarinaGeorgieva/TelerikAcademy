// Problem 16. Date difference

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Linq;
using System.Text;

class DateDifference
{
    static void Main(string[] args)
    {
        Console.Write("Enter first date in the format: day.month.year: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date in the format: day.month.year: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        if (firstDate > secondDate)
        {
            DateTime temp = firstDate;
            firstDate = secondDate;
            secondDate = temp;
        }

        Console.WriteLine("Number of days between the two dates: {0}", (secondDate - firstDate).TotalDays);
    }
}


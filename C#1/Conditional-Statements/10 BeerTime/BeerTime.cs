// Problem 10.* Beer Time

// A beer time is after 1:00 PM and before 3:00 AM.
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
// and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 

using System;

class BeerTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time: ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            DateTime start = DateTime.Parse("1:00 PM");
            DateTime end = DateTime.Parse("3:00 AM");

            if (dateTime >= start && dateTime < end) 
            {
                Console.WriteLine("It's beer time!");
            }
            else if (dateTime < start || dateTime > end) 
            {
                Console.WriteLine("It's not beer time!");
            }
            else
            {
                Console.WriteLine("The entered time is invalid!");
            }



        }
    }


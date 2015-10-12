// Problem 17. Date in Bulgarian

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");                
        CultureInfo provider = CultureInfo.GetCultureInfo("bg-BG");

        Console.Write("Enter date and time in the format: day.month.year hour:minute:second: ");
        DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy HH:mm:ss", provider);

        DateTime newDateTime = dateTime.AddHours(6).AddMinutes(30);
        Console.WriteLine("Date and time after 6 hours and 30 minutes and day of week are: ");
        Console.WriteLine("{0}, {1}", newDateTime, DateTimeFormatInfo.CurrentInfo.GetDayName(newDateTime.DayOfWeek));
    }
}


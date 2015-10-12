// Problem 5. Workdays

// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;

class WorkDays
{
    static DateTime[] holidays = 
    { 
        new DateTime(2015, 01, 01),
        new DateTime(2015, 01, 02),
        new DateTime(2015, 03, 02),
        new DateTime(2015, 03, 03),
        new DateTime(2015, 04, 10),
        new DateTime(2015, 04, 13),
        new DateTime(2015, 05, 01),
        new DateTime(2015, 05, 06),
        new DateTime(2015, 09, 21),
        new DateTime(2015, 09, 22),
        new DateTime(2015, 12, 24),
        new DateTime(2015, 12, 25),
        new DateTime(2015, 12, 31)
    };

    static DateTime[] workSaturdays = 
    {
        new DateTime(2015, 01, 24),
        new DateTime(2015, 03, 21),
        new DateTime(2015, 09, 12),
        new DateTime(2015, 12, 12)
    };

    static void Main(string[] args)
    {
        Console.Write("Enter a date between today and 2015/12/31 in format year/month/day: ");
        string[] futureDateStr = Console.ReadLine().Split('/');

        int futureYear = int.Parse(futureDateStr[0]);
        int futureMonth = int.Parse(futureDateStr[1]);
        int futureDay = int.Parse(futureDateStr[2]);

        DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        DateTime futureDate = new DateTime(futureYear, futureMonth, futureDay);

        if (today <= futureDate)
        {
            Console.WriteLine("{0} working days from {1:yyyy/MM/dd} to {2:yyyy/MM/dd}", GetNumberOfWorkdays(today, futureDate), today, futureDate);
        }
        else
        {
            Console.WriteLine("{0} working days from {1:yyyy/MM/dd} to {2:yyyy/MM/dd}", GetNumberOfWorkdays(today, futureDate), futureDate, today);
        }


    }

    static int GetNumberOfWorkdays(DateTime today, DateTime futureDate)
    {
        int countWorkDays = 0;

        if (today > futureDate)
        {
            today = futureDate;
            futureDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        while (today <= futureDate)
        {
            if ((today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(today)) || 
                workSaturdays.Contains(today))
            {
                countWorkDays++;
            }
            today = today.AddDays(1);
        }

        return countWorkDays;
    }
}


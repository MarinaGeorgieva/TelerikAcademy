// Problem 19. Dates from text in Canada

// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        CultureInfo provider = CultureInfo.GetCultureInfo("en-CA");

        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        DateTime date;

        foreach (Match item in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", provider, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }  
    }
}


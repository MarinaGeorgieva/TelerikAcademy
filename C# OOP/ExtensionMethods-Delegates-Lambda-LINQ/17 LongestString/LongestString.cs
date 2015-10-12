// Problem 17. Longest string

// Write a program to return the string with maximum length from an array of strings.
// Use LINQ.

namespace _17_LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestString
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = { "Pesho", "Ivan", "Mariika", "Ivo", "Nikolay", "Zornitsa", "Georgi"};

            var stringsOrderedByLength =
                from str in arrayOfStrings
                orderby str.Length descending
                select str;

            string stringWithMaxLength = stringsOrderedByLength.First();

            Console.WriteLine("String with max length: {0}", stringWithMaxLength);
        }
    }
}

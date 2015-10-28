namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 4, 7, -5, -2, -8, 0, 27, 21, -16, 3, -3, -1, 2, 6};
            Console.WriteLine("Before removing");
            Console.WriteLine(string.Join(", ", numbers));

            numbers.RemoveAll(n => n < 0);
            Console.WriteLine("After removing negative numbers");
            Console.WriteLine(string.Join(", ", numbers));
        }        
    }
}

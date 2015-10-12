// Problem 3. Range Exceptions

// Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
// It should hold error message and a range definition [start … end].
// Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
// by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace _03_RangeExceptions
{
    using System;
    using System.Globalization;

    public class ExceptionTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Number must be in range [1..100]", 1, 100);
                }
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine(ire.Message);
                Console.WriteLine(ire.StackTrace);
            }
            finally
            {
                Console.WriteLine();
            }

            Console.Write("Enter date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            try
            {
                if (date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Date must be in range [1.1.1980 ... 31.12.2013]", startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine(ire.Message);
                Console.WriteLine(ire.StackTrace);
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}

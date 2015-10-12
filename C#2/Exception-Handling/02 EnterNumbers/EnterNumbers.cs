// Problem 2. Enter numbers

// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumbers
{
    static void Main(string[] args)
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(2, 99);
            }
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException aore)
        {
            Console.WriteLine(aore.Message);
        }
    }

    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter a number in range [{0}, {1}]: ", start, end);
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }
}


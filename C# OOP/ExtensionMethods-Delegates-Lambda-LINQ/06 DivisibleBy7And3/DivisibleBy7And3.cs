// Problem 6. Divisible by 7 and 3

// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06_DivisibleBy7And3
{
    using System;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 17, 5, 21, 3, 14, 63, 26, 3, 42, 92, 84, 16, 9 };

            var divisibleWithLambda = array.Where(number => number % 3 == 0 && number % 7 == 0);

            foreach (int number in divisibleWithLambda)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine();

            var divisibleWithLinq =
                from number in array
                where number % 3 == 0 && number % 7 == 0
                select number;

            foreach (int number in divisibleWithLinq)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

﻿namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array cannot be null");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("Start index is out of bounds");
            }

            if (count < 0)
            {
                throw new ArgumentException("Count must be greater than 0");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("The length of the subsequence is too big");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException("String cannot be null");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("Count cannot be greater than length of string");
            }
            
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            bool isPrime = true;

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }

        public static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));            

            try
            {
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}

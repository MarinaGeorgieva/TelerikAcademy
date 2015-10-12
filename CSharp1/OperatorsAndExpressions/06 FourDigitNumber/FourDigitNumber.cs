// Problem 6. Four-Digit Number

// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four-digit number: ");
            int number = int.Parse(Console.ReadLine());

            int a = number / 1000;
            int b = number % 1000 / 100;
            int c = number % 1000 % 100 / 10;
            int d = number % 1000 % 100 % 10;

            int sum = a + b + c + d;
            Console.WriteLine("Sum of the digits of the number {0} is {1}", number, sum);
            Console.WriteLine("The number {0} in reversed order is {1}{2}{3}{4}", number, d, c, b, a);
            Console.WriteLine("The number {0} with last digit in the first position is {1}{2}{3}{4}", number, d, a, b, c);
            Console.WriteLine("The number {0} with exchanged second and third digit is {1}{2}{3}{4}", number, a, c, b, d);
        }
    }


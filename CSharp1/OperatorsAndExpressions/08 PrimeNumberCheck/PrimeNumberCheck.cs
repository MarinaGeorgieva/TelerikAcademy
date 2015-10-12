// Problem 8. Prime Number Check

// Write an expression that checks if given positive integer number n (n = 100) is prime 
// (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number >= 1)
        {
            if (number == 1)
            {
                isPrime = false;
            }
            else if (number == 2)
            {
                isPrime = true;
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(number) + 1; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }                
            }
            Console.WriteLine("The number {0} is prime ---> {1}", number, isPrime);
        } 
        else 
        {
            Console.WriteLine("The number {0} is NOT prime", number);
        }
    }
}


// Problem 10. Odd and Even Product

// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {       
        Console.WriteLine("Enter n numbers in a single line, separated by a space: ");
        string[] numbers = Console.ReadLine().Split(' ');       
        
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= int.Parse(numbers[i]);
            }
            else
            {
                evenProduct *= int.Parse(numbers[i]);
            }
        }     
        
        Console.WriteLine("Product of odd elements is equal to the product of even elements ---> {0}", oddProduct == evenProduct);
        
    }
}


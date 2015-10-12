// Problem 11.* Number as Words

// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberAsWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int hundreds = number / 100;
        int tens = number % 100 / 10;
        int ones = number % 100 % 10;

        if (hundreds > 0)
        {
            switch (hundreds)
            {
                case 1: Console.Write("One hundred ");
                    break;
                case 2: Console.Write("Two hundred ");
                    break;
                case 3: Console.Write("Three hundred ");
                    break;
                case 4: Console.Write("Four hundred ");
                    break;
                case 5: Console.Write("Five hundred ");
                    break;
                case 6: Console.Write("Six hundred ");
                    break;
                case 7: Console.Write("Seven hundred ");
                    break;
                case 8: Console.Write("Eight hundred ");
                    break;
                case 9: Console.Write("Nine hundred ");
                    break;
            }
            if ((tens != 0) || (tens == 0 && ones != 0))
            {
                Console.Write("and ");
            }
        }
        
        if (tens > 1)
        {
            switch (tens)
            {                
                case 2: Console.Write("Twenty ");
                    break;
                case 3: Console.Write("Thirty ");
                    break;
                case 4: Console.Write("Fourty ");
                    break;
                case 5: Console.Write("Fifty ");
                    break;
                case 6: Console.Write("Sixty ");
                    break;
                case 7: Console.Write("Seventy ");
                    break;
                case 8: Console.Write("Eighty ");
                    break;
                case 9: Console.Write("Ninety ");
                    break;
            }
        }
        else if (tens == 1)
        {
            switch (ones)
            {
                case 0: Console.Write("Ten");
                    break;
                case 1: Console.Write("Eleven ");
                    break;
                case 2: Console.Write("Twelve");
                    break;
                case 3: Console.Write("Thirteen");
                    break;
                case 4: Console.Write("Fourteen");
                    break;
                case 5: Console.Write("Fifteen");
                    break;
                case 6: Console.Write("Sixteen");
                    break;
                case 7: Console.Write("Seventeen");
                    break;
                case 8: Console.Write("Eighteen");
                    break;
                case 9: Console.Write("Nineteen");
                    break;
            }
        }
        if (tens != 1)
        {
            switch (ones)
            {                
                case 1: Console.Write("One ");
                    break;
                case 2: Console.Write("Two");
                    break;
                case 3: Console.Write("Three");
                    break;
                case 4: Console.Write("Four");
                    break;
                case 5: Console.Write("Five");
                    break;
                case 6: Console.Write("Six");
                    break;
                case 7: Console.Write("Seven");
                    break;
                case 8: Console.Write("Eight");
                    break;
                case 9: Console.Write("Nine");
                    break;
            }
        }        

        if (hundreds == 0 && tens == 0 && ones == 0)
        {
            Console.Write("Zero");
        }

        Console.WriteLine();
    }
}


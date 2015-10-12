// Problem 11. Bitwise: Extract Bit #3

// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

using System;

class ExtractBit3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        int position = 3;

        int mask = 1 << position;
        int numberAndMask = (int) number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("Bit #3 of the number {0} is {1}", number, bit);
        Console.WriteLine("Binary representation of the number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

    }
}


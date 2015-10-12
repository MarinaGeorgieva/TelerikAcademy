// Problem 12. Extract Bit from Integer

// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int numberAndMask = (int)number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("Bit #{0} of the number {1} is {2}", position, number, bit);
        Console.WriteLine("Binary representation of the number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}


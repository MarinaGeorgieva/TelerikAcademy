// Problem 13. Check a Bit at Given Position

// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
// in given integer number n, has value of 1.

using System;

class CheckBit
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
        bool isOne = bit == 1;
        Console.WriteLine("Bit #{0} of the number {1} is 1 ---> {2}", position, number, isOne);
        Console.WriteLine("Binary representation of the number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}


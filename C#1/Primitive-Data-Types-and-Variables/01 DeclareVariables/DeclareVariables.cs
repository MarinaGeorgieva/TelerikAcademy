// Problem 1. Declare Variables

// Declare five variables choosing for each of them the most appropriate of the types 
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariables
{
    static void Main(string[] args)
    {
       byte firstValue = 97;
       ushort secondValue = 52130;
       sbyte thirdValue = -115;
       uint fourthValue = 4825932;
       short fifthValue = -10000;

       Console.WriteLine("First value: {0}\nSecond value: {1}\nThird value: {2}\nFourth value: {3}\nFifth value: {4}", 
           firstValue, secondValue, thirdValue, fourthValue, fifthValue);
    }
}


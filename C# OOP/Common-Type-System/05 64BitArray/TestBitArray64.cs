// Problem 5. 64 Bit array

// Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace _05_64BitArray
{
    using System;

    public class TestBitArray64
    {
        static void Main(string[] args)
        {
            BitArray64 bitArray1 = new BitArray64(21u);
            BitArray64 bitArray2 = new BitArray64(2134u);

            Console.WriteLine(bitArray1);
            Console.WriteLine(bitArray2);

            bitArray1[4] = 0;
            bitArray1[28] = 1;
            bitArray1[40] = 1;
            bitArray1[63] = 1;

            foreach (var bit in bitArray1)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(bitArray1.Equals(bitArray2));
            Console.WriteLine(bitArray1 == bitArray2);
            Console.WriteLine(bitArray1 != bitArray2);
        }
    }
}

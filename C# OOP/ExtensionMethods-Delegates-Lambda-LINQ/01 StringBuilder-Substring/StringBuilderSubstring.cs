// Problem 1. StringBuilder.Substring

// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
// new StringBuilder and has the same functionality as Substring in the class String.

namespace _01_StringBuilder_Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);

            string str = stringBuilder.ToString();

            if (index < 0 || index >= str.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (length < 0 || (index + length) >= str.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int ind = index; ind < index + length; ind++)
            {
                result.Append(str[ind]);
            }

            return result;
        }
    }
}

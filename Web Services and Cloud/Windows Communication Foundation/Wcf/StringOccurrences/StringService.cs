namespace StringOccurrences
{
    using System;

    public class StringService : IStringService
    {
        public int CountOccurrences(string first, string second)
        {
            if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
            {
                throw new ArgumentNullException("First or second string cannot be null or empty!");
            }

            if (first.Length > second.Length)
            {
                return 0;
            }
            
            if (second.IndexOf(first) == -1)
            {
                return 0;
            }

            int foundIndex = second.IndexOf(first);
            int count = 1;

            while (second.IndexOf(first, foundIndex + 1) > - 1)
            {
                count++;
                foundIndex = second.IndexOf(first, foundIndex + 1);
            }

            return count;
        }
    }
}

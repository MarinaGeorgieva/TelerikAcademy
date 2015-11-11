namespace BinaryPasswords
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            var starsCount = Console.ReadLine().Count(c => c == '*');

            Console.WriteLine((BigInteger)Math.Pow(2, starsCount));
        }
    }
}

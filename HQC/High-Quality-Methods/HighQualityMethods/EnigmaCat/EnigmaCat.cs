namespace EnigmaCat
{
    using System;
    using System.Numerics;
    using System.Text;

    public class EnigmaCat
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int power = 0;
            BigInteger decimalNumber = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currentNumber = input[i];
                for (int j = currentNumber.Length - 1; j >= 0; j--)
                {
                    int currentDigit = (int)(currentNumber[j] - 'a');
                    decimalNumber += currentDigit * Power(17, power);
                    power++;
                }

                string numberConvertedTo26NumeralSystem = ConvertFromDecTo26NumeralSystem(decimalNumber);
                result.Append(numberConvertedTo26NumeralSystem + " ");

                power = 0;
                decimalNumber = 0;
            }

            Console.WriteLine(result);
        }

        private static string ConvertFromDecTo26NumeralSystem(BigInteger number)
        {
            const int BaseToConvertTo = 26;
            StringBuilder resultNumber = new StringBuilder();

            do
            {
                resultNumber.Append((char)((number % BaseToConvertTo) + 'a'));
                number /= BaseToConvertTo;
            } 
            while (number != 0);

            StringBuilder reversedResult = new StringBuilder();

            for (int i = resultNumber.Length - 1; i >= 0; i--)
            {
                reversedResult.Append(resultNumber[i]);
            }

            return reversedResult.ToString();
        }

        private static BigInteger Power(int number, int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

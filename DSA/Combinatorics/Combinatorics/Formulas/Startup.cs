namespace Formulas
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var expression = Console.ReadLine();
            char firstVariable = expression[1];
            char secondVariable = expression[3];

            var emptyLine = Console.ReadLine();

            int power = int.Parse(Console.ReadLine());

            PrintFormula(firstVariable, secondVariable, power);
        }

        private static void PrintFormula(char firstVariable, char secondVariable, int power)
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("({0}^{1})+", firstVariable, power);

            for (int i = 1; i < power; i++)
            {
                result.AppendFormat(
                    "{0}({1}^{2})({3}^{4})+",
                    BinomialCoeff(power, i),
                    firstVariable,
                    power - i,
                    secondVariable,
                    i);
            }

            result.AppendFormat("({0}^{1})", secondVariable, power);

            Console.WriteLine(result.ToString());
        }

        private static long BinomialCoeff(int n, int k)
        {
            long result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= n - (k - i);
                result /= i;
            }

            return result;
        }
    }
}

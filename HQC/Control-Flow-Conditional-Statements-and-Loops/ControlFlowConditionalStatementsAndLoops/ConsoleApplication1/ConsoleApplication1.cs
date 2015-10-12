namespace ConsoleApplication1
{
    using System;
    using System.Numerics;

    public class ConsoleApplication1
    {
        public static void Main()
        {
            string input = "";

            BigInteger counter = 0;
            BigInteger productOfFirstTenNumbers = 1;
            BigInteger productAfterTenthNumber = 1;

            do
            {
                input = Console.ReadLine();

                if (counter % 2 != 0 && input != "END")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == '0')
                        {
                            continue;
                        }
                        else
                        {
                            if (counter < 10)
                            {
                                productOfFirstTenNumbers *= (input[i] - '0');
                            }
                            else
                            {
                                productAfterTenthNumber *= (input[i] - '0');
                            }
                        }
                    }
                }
                counter++;
            } while (input != "END");

            Console.WriteLine(productOfFirstTenNumbers);

            if (counter > 10)
            {
                Console.WriteLine(productAfterTenthNumber);
            }      
        }
    }
}

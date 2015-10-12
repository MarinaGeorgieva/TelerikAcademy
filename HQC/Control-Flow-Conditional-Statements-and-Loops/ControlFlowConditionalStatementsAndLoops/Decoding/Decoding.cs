namespace Decoding
{
    using System;

    public class Decoding
    {
        public static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();

            int counter = 0;

            foreach (char symbol in inputText)
            {
                if (symbol == '@')
                {
                    break;
                }
                else if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
                {
                    int letter = symbol * salt + 1000;

                    if (counter % 2 == 0)
                    {
                        double decodedText = (double)letter / 100;
                        Console.WriteLine("{0:0.00}", decodedText);
                    }
                    else
                    {
                        int decodedText = letter * 100;
                        Console.WriteLine(decodedText);
                    }
                    counter++;
                }

                else if (symbol >= '0' && symbol <= '9')
                {
                    int digit = symbol + salt + 500;

                    if (counter % 2 == 0)
                    {
                        double decodedText = (double)digit / 100;
                        Console.WriteLine("{0:0.00}", decodedText);
                    }
                    else
                    {
                        int decodedText = digit * 100;
                        Console.WriteLine(decodedText);
                    }
                    counter++;
                }
                else
                {
                    int other = symbol - salt;

                    if (counter % 2 == 0)
                    {
                        double decodedText = (double)other / 100;
                        Console.WriteLine("{0:0.00}", decodedText);
                    }
                    else
                    {
                        int decodedText = other * 100;
                        Console.WriteLine(decodedText);
                    }
                    counter++;
                }
            }
        }
    }
}

namespace ThreeNumbers
{
    using System;

    public class ThreeNumbers
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());

            long sum = firstNumber + secondNumber + thirdNumber;
            double arithmeticMean = (double)sum / 3;

            long biggest = firstNumber;
            long smallest = firstNumber;

            if (secondNumber > biggest)
            {
                biggest = secondNumber;
            }

            if (thirdNumber > biggest)
            {
                biggest = thirdNumber;
            }

            if (secondNumber < smallest)
            {
                smallest = secondNumber;
            }

            if (thirdNumber < smallest)
            {
                smallest = thirdNumber;
            }

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:0.00}", arithmeticMean);
        }
    }
}

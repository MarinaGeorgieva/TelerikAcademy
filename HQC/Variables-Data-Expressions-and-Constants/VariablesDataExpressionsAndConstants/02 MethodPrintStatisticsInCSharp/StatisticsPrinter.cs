namespace _02_MethodPrintStatisticsInCSharp
{
    using System;

    public class StatisticsPrinter
    {
        public void PrintStatistics(double[] numbers, int count)
        {
            double largestNumber = double.MinValue;
            double smallestNumber = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }

                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }

                sum += numbers[i];
            }

            this.PrintMax(largestNumber);
            this.PrintMin(smallestNumber);

            double average = sum / count;
            this.PrintAverage(average);
        }

        private void PrintMax(double largestNumber)
        {
            Console.WriteLine("The largest number in the array is {0}", largestNumber);
        }

        private void PrintMin(double smallestNumber)
        {
            Console.WriteLine("The smallest number in the array is {0}", smallestNumber);
        }

        private void PrintAverage(double average) 
        {
            Console.WriteLine("The average of the numbers in the array is {0}", average);   
        }
    }
}

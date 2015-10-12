namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class FunctionPerformanceTester
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();
        private const float FloatValue = 100.0F;
        private const double DoubleValue = 100.0;
        private const decimal DecimalValue = 100.0M;
        private const int FunctionsCount = 1000000;

        static FunctionPerformanceTester()
        {
            Console.WriteLine("Test math functions 1M times with float, double and decimal variables set at value 100.0.");
        }

        public static void TestPerformance(Function function)
        {
            Console.WriteLine("-------" + function + "-------");

            float resultFloat = FloatValue;
            Stopwatch.Start();

            for (int i = 0; i < FunctionsCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultFloat = (float)Math.Sqrt(FloatValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultFloat = (float)Math.Log(FloatValue);
                        break;
                    case Function.Sinus:
                        resultFloat = (float)Math.Sin(FloatValue);
                        break;                    
                    default:
                        throw new InvalidOperationException("Invalid function");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Float", Stopwatch.Elapsed);
            Stopwatch.Reset();

            double resultDouble = DoubleValue;
            Stopwatch.Start();

            for (int i = 0; i < FunctionsCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultDouble = Math.Sqrt(DoubleValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultDouble = Math.Log(DoubleValue);
                        break;
                    case Function.Sinus:
                        resultDouble = Math.Sin(DoubleValue);
                        break;                    
                    default:
                        throw new InvalidOperationException("Invalid function");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Double", Stopwatch.Elapsed);
            Stopwatch.Reset();

            decimal resultDecimal = DecimalValue;
            Stopwatch.Start();

            for (int i = 0; i < FunctionsCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultDecimal = (decimal)Math.Sqrt((double)DecimalValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultDecimal = (decimal)Math.Log((double)DecimalValue);
                        break;
                    case Function.Sinus:
                        resultDecimal = (decimal)Math.Sin((double)DecimalValue);
                        break;                    
                    default:
                        throw new InvalidOperationException("Invalid function");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Decimal", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}

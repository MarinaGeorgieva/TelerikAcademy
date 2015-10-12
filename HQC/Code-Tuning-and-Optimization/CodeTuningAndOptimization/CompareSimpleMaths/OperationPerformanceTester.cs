namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class OperationPerformanceTester
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();
        private const int IntegerValue = 1;
        private const long LongValue = 1L;
        private const float FloatValue = 1.0F;
        private const double DoubleValue = 1.0;                
        private const decimal DecimalValue = 1.0M;
        private const int OperationsCount = 1000000;

        static OperationPerformanceTester()
        {
            Console.WriteLine("Test math operations 1M times with all variables set at value 1.");
        }

        public static void TestPerformance(Operation operation)
        {
            Console.WriteLine("-------" + operation + "-------");

            int resultInt = IntegerValue;
            Stopwatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultInt += IntegerValue;
                        break;
                    case Operation.Subtraction:
                        resultInt -= IntegerValue;
                        break;
                    case Operation.Multiplication:
                        resultInt *= IntegerValue;
                        break;
                    case Operation.Division:
                        resultInt /= IntegerValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Int", Stopwatch.Elapsed);
            Stopwatch.Reset();

            long resultLong = LongValue;
            Stopwatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultLong += LongValue;
                        break;
                    case Operation.Subtraction:
                        resultLong -= LongValue;
                        break;
                    case Operation.Multiplication:
                        resultLong *= LongValue;
                        break;
                    case Operation.Division:
                        resultLong /= LongValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Long", Stopwatch.Elapsed);
            Stopwatch.Reset();

            float resultFloat = FloatValue;
            Stopwatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultFloat += FloatValue;
                        break;
                    case Operation.Subtraction:
                        resultFloat -= FloatValue;
                        break;
                    case Operation.Multiplication:
                        resultFloat *= FloatValue;
                        break;
                    case Operation.Division:
                        resultFloat /= FloatValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Float", Stopwatch.Elapsed);
            Stopwatch.Reset();

            double resultDouble = DoubleValue;
            Stopwatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultDouble += DoubleValue;
                        break;
                    case Operation.Subtraction:
                        resultDouble -= DoubleValue;
                        break;
                    case Operation.Multiplication:
                        resultDouble *= DoubleValue;
                        break;
                    case Operation.Division:
                        resultDouble /= DoubleValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Double", Stopwatch.Elapsed);
            Stopwatch.Reset();

            decimal resultDecimal = DecimalValue;
            Stopwatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultDecimal += DecimalValue;
                        break;
                    case Operation.Subtraction:
                        resultDecimal -= DecimalValue;
                        break;
                    case Operation.Multiplication:
                        resultDecimal *= DecimalValue;
                        break;
                    case Operation.Division:
                        resultDecimal /= DecimalValue;
                        break;
                    default:
                        throw new InvalidOperationException("InvalidOperation");
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Decimal", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

    }
}

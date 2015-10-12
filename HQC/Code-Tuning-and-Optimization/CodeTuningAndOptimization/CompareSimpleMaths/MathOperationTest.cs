namespace CompareSimpleMaths
{
    using System;

    public class MathOperationTest
    {
        public static void Main()
        {
            OperationPerformanceTester.TestPerformance(Operation.Addition);
            OperationPerformanceTester.TestPerformance(Operation.Subtraction);
            OperationPerformanceTester.TestPerformance(Operation.Multiplication);
            OperationPerformanceTester.TestPerformance(Operation.Division);
        }
    }
}

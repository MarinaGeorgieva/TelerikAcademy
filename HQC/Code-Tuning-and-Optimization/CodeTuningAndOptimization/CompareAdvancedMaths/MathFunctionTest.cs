namespace CompareAdvancedMaths
{
    using System;

    public class MathFunctionTest
    {
        public static void Main()
        {
            FunctionPerformanceTester.TestPerformance(Function.SquareRoot);
            FunctionPerformanceTester.TestPerformance(Function.NaturalLogarithm);
            FunctionPerformanceTester.TestPerformance(Function.Sinus);
        }
    }
}

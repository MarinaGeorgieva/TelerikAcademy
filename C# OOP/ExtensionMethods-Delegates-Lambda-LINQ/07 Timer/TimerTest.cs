// Problem 7. Timer

// Using delegates write a class Timer that can execute certain method at each t seconds.

namespace _07_Timer
{
    using System;
    using System.Diagnostics;

    class TimerTest
    {
        private static Stopwatch sw = new Stopwatch();

        static void Main()
        {
            sw.Start();

            Timer timer = new Timer(3, 7);
            timer.Methods += TestMethodOne;
            timer.Methods += TestMethodTwo;
            timer.Execute();
        }

        public static void TestMethodOne()
        {
            Console.WriteLine("TestMethodOne executed"); 
            Console.WriteLine("Seconds passed: {0}", sw.ElapsedMilliseconds / 1000);
        }

        public static void TestMethodTwo()
        {
            Console.WriteLine("TestMethodTwo executed");
            Console.WriteLine("Seconds passed: {0}", sw.ElapsedMilliseconds / 1000);
        }
    }
}

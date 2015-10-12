// Problem 8.* Events

// Read in MSDN about the keyword event in C# and how to publish events.
// Re-implement the above using .NET events and following the best practices.

namespace _08_Events
{
    using System;
    using System.Threading;

    public class TimerEventMain
    {
        static void Main()
        {
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber(pub);
            pub.Tick(3, 7);
        }
    }
}

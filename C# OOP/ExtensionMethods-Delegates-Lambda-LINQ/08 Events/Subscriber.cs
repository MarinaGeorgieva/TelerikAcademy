namespace _08_Events
{
    using System;
    using System.Threading;

    public class Subscriber
    {
        public Subscriber(Publisher pub)
        {
            pub.RaiseTimerEvent += HandleTimerEvent;
        }

        public void HandleTimerEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Timer event was reached.");
        }
    }
}

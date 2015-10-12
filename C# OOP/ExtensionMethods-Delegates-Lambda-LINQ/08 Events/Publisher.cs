namespace _08_Events
{
    using System;
    using System.Threading;

    public delegate void TimerEventHandler(object sender, Publisher pub);

    public class Publisher : EventArgs
    {
        public event EventHandler RaiseTimerEvent;

        public void Tick(int ticks, int seconds)
        {
            while (ticks > 0)
            {
                Thread.Sleep(seconds * 1000);
                ticks--;
                OnRaiseTimerEvent();
            }
        }

        protected virtual void OnRaiseTimerEvent()
        {
            EventHandler handler = RaiseTimerEvent;

            if (handler != null)
            {
                handler(this, null);
            }
        }
    }
}

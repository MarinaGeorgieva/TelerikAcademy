namespace _07_Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    { 
        private int seconds;
        private int ticks;

        public Timer(int seconds, int ticks)
        {
            this.Seconds = seconds;
            this.Ticks = ticks;
        }       

        public int Seconds 
        { 
            get
            {
                return this.seconds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Seconds must be positive number");
                }

                this.seconds = value;
            }
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ticks must be positive number");
                }

                this.ticks = value;
            }
        }

        public TimerDelegate Methods { get; set; }

        public void Execute()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Seconds * 1000);
                ticks--;
                Methods();
            }
        }
    }
}

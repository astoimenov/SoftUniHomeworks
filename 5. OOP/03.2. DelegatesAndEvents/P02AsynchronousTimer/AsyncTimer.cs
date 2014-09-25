namespace P02AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsyncTimer
    {
        private readonly Action method;
        private int ticks;
        private int interval;

        public AsyncTimer(Action method, int ticks, int interval)
        {
            this.method = method;
            this.ticks = ticks;
            this.interval = interval;
            this.OnTick(EventArgs.Empty);
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ticks", "Ticks can't be negative!");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval", "Interval can't be negative!");
                }
                
                this.interval = value;
            }
        }

        public virtual void OnTick(EventArgs eventArgs)
        {
            if (this.method != null)
            {
                Thread newThread = new Thread(() =>
                {
                    int passedTicks = 0;
                    while (passedTicks < this.ticks)
                    {
                        this.method();
                        passedTicks++;
                        Thread.Sleep(this.interval);
                    }
                });
                newThread.Start();
            }
        }
    }
}

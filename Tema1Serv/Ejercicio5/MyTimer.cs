using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public delegate void delegateFunction();
    class MyTimer
    {
        public int Interval { set; get; }
        private Thread thread;
        private delegateFunction function;
        static readonly object l = new object();
        private bool toStop = true;

        public MyTimer(delegateFunction function)
        {
            this.function = function;
            thread = new Thread(timer);
            thread.IsBackground = true;
            thread.Start();
        }

        private void timer()
        {
            while (true)
            {
                lock (l) {
                    if (toStop)
                    {
                        Monitor.Wait(l);
                    }
                        function.Invoke();
                }
                Thread.Sleep(Interval);
            }
        }

        public void star()
        {
            toStop = false;
            lock (l)
            {
                Monitor.Pulse(l);
            }
        }

        public void stop()
        {

            toStop = true;
        }

    }
}

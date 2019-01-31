
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public delegate int Incremento(int i);
    class Program
    {
        static int i = 0;
        static readonly object l = new object();
        static bool flag = true;

        static void Main(string[] args)
        {

            new Thread(()=>
            {
                while(Math.Abs(i) < 100)
                {
                    lock (l)
                    {
                        if (flag)
                        {
                            i++;
                            Console.Write("Thread 1: {0}\n", i);
                            if (Math.Abs(i) < 100) {
                                flag = false;
                                Monitor.Pulse(l);
                            }
                        }
                        //else Monitor.Pulse(l);
                    }
                }
                //flag = false;
                
            }).Start();

            new Thread(() =>
            {
                while (Math.Abs(i) < 100)
                {
                    lock (l) {
                        if (flag) {
                            i--;
                            Console.Write("Thread 2: {0}\n", i);
                            if (Math.Abs(i) < 100)
                            {
                                flag = false;
                                Monitor.Pulse(l);
                            }
                        }
                        //else Monitor.Pulse(l);
                    }
                }
                //flag = false;
            }).Start();

            //h1.Join();
            //h2.join();
            lock (l)
            {
                Monitor.Wait(l);
                Console.WriteLine("The thread {0} win", i == 100 ? 1 : 2);
                Console.ReadKey();
            }
        }

    }
}

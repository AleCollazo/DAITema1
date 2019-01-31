using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{

    class Program
    {
        static int counter = 0;
        //static readonly object l = new object();

        static void increment()
        {
            counter++;
            Console.SetCursorPosition(5, 10);
            Console.WriteLine(counter);
        }

        private static void pintarCounter()
        {
            Console.SetCursorPosition(5, 10);
            Console.WriteLine(counter);
            Console.SetCursorPosition(0, 0);
        }

        static void Main(string[] args)
        {
            MyTimer t = new MyTimer(increment);
            t.Interval = 1000;
            string op = "";

            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            do
            {
                t.star();
                Console.Clear();
                Console.WriteLine("Press any key to stop");
                Console.ReadKey();
                t.stop();
                Console.Clear();
                pintarCounter();
                Console.WriteLine("Press 1 to continue or Enter to end");
                op = Console.ReadLine();
                Console.Clear();
                pintarCounter();
            } while (op == "1");
        }
    }
}

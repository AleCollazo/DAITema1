using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static readonly object l = new object();

        static void Main(string[] args)
        {
            Random ram = new Random();
        }

        static void player(Random ram, int leftPosition)
        {
            int num;

            while (true) {
                lock (l) {
                    num = ram.Next(1, 10);
                    Console.WriteLine("{0}", 100 * num);
                    Console.SetCursorPosition(leftPosition, 5);
                }
            }
        }

    }
}

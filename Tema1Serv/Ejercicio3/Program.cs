using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {


        static void Main(string[] args)
        {
            Thread thread = new Thread(decrementacion);
            thread.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("{0} ",i);
            }

            Console.Read();
        }

        static void decrementacion()
        {
            for (int i = 0; i > -1000; i--)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}

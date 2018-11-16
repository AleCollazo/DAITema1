
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


        static void Main(string[] args)
        {

            new Thread(()=>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("{0} ",i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i > -100; i--)
                {
                    Console.Write("{0} ", i);
                }
            }).Start();

            Console.ReadKey();

        }

    }
}

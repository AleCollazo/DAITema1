using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static readonly private object l = new object();

        static int winnerHorseId = -1;
        static bool flag = true;

        static void RunHorse(object horse)
        {
            int avance = 0;

            Random random = ((Horse)horse).Random;
            int idHorse = ((Horse)horse).Id;
            string dorsalCaballo = (idHorse + 1).ToString();

            lock (l)
            {
                Console.SetCursorPosition(0, idHorse + 3);
                Console.Write("{0," + avance + "}", dorsalCaballo);
            }
            //Thread.Sleep(random.Next(1000, 5000));

            while (flag) {
                lock (l)
                {
                    if (flag)
                    {
                        avance += 1;// random.Next(1, 10);
                        Console.SetCursorPosition(0, idHorse + 3);
                        Console.Write("{0,"+avance+"}", dorsalCaballo);
                        if (avance > 80)
                        {
                            flag = false;
                            winnerHorseId = idHorse;
                            Monitor.Pulse(l);
                        }
                    }
                    Thread.Sleep(5);// random.Next(1000, 5000));
                }
            }
        }

        static void dibujarMeta()
        {
            for (int i = 2; i <= 8; i++)
            {
                Console.SetCursorPosition(80, i);
                Console.Write("|");
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Thread[] horses = new Thread[5];

            int caballoEscogido = 0;

            Console.WriteLine("Seleciona el número de dorsal del caballo por el que apuestas:\n");
            for (int i = 1; i <= horses.Length; i++)
            {
                Console.Write("{0}\t", i);
            }

            Console.WriteLine("\n");

            do
            {
                try
                {
                    caballoEscogido = Convert.ToInt32(Console.ReadLine());
                    if (caballoEscogido <= 0 || caballoEscogido > horses.Length)
                    {
                        Console.WriteLine("Caballo inexistente");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Introduce valores numéricos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Valor inválido");
                }
                
            } while (caballoEscogido <= 0 || caballoEscogido > horses.Length);

            Console.Clear();
            Console.Write("Caballo apostado: {0}", caballoEscogido);

            dibujarMeta();

            for (int i = 0; i < 5; i++)
            {
                horses[i] = new Thread(RunHorse);
                horses[i].IsBackground = true;
                horses[i].Start(new Horse(i, rand));
            }

            lock (l) {
                Monitor.Wait(l);
                int caballoGanador = winnerHorseId + 1;
                Console.SetCursorPosition(0, 20);
                if (caballoEscogido == caballoGanador)
                {
                    Console.WriteLine("¡Tu caballo ha ganado!");
                }
                else
                {
                    Console.WriteLine("Tu caballo ha perdido");
                    Console.WriteLine("El caballo ganador es el caballo número {0}", caballoGanador);
                }

                Console.ReadLine();
            }
        }
    }
}

﻿using System;
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

        static void RunHorse(object horse)
        {
            int avance = 0;
            bool flag = true;

            Random random = ((Horse)horse).Random;
            int idHorse = ((Horse)horse).Id;

            lock (l)
            {
                Console.SetCursorPosition(0, idHorse + 3);
                Console.Write("{0," + avance + "}", "*");
            }
            Thread.Sleep(random.Next(1000, 5000));

            while (flag) {
                if (flag) {
                    lock (l) {
                        avance += random.Next(1, 10);
                        Console.SetCursorPosition(0, idHorse + 3);
                        Console.Write("{0,"+avance+"}", "*");
                        if (avance >= 80)
                        {
                            flag = false;
                            winnerHorseId = idHorse;
                            Monitor.Wait(l);
                        }
                    }
                    Thread.Sleep(random.Next(1000, 5000));
                }
            }
        }


        static void Main(string[] args)
        {
            Random rand = new Random();
            Thread[] horses = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                horses[i] = new Thread(RunHorse);
                horses[i].Start(new Horse(i, rand));
            }

            while (true)
            {
                if (winnerHorseId != -1) {
                    Console.SetCursorPosition(0, 20);
                    //Console.WriteLine(winnerHorseId);
                    Console.WriteLine("El caballo ganador es el caballo número: {0}", winnerHorseId);
                    Console.Read();
                }
            }
        }
    }
}

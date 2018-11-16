using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static readonly object l = new object();
        static bool isBlinking = true;
        static short playerNum = 0;
        static int puntuation = 0;
        static bool isPaused = false;
        static bool starGame = true;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Random ram = new Random();

            paint();
            writePuntuation();

            Thread.Sleep(500);

            Thread jugador1 = new Thread(player);
            Thread jugador2 = new Thread(player);
            Thread threadDisplay = new Thread(display);

            jugador1.Start(new Parameters(ram, 1, 10));
            jugador2.Start(new Parameters(ram, 2, 40));
            threadDisplay.Start();

            jugador1.IsBackground = true;
            jugador2.IsBackground = true;
            threadDisplay.IsBackground = true;

            

            while (true) {
                lock (l)
                {
                    if (isPaused)
                    {
                        if (playerNum == 1)
                        {
                            if (isBlinking)
                            {
                                puntuation += 1;
                                isBlinking = false;
                            }
                            else
                            {
                                puntuation += 5;
                            }
                            starGame = false;
                            writePuntuation();
                        }
                        if (playerNum == 2)
                        {
                            if (isBlinking)
                            {
                                if (starGame) puntuation -= 1;
                                else puntuation -= 5;
                            }
                            else
                            {
                                puntuation -= 1;
                                isBlinking = true;
                            }
                            starGame = false;
                            writePuntuation();
                        }
                        playerNum = 0;
                        Monitor.Pulse(l);
                        isPaused = false;

                        

                        if (puntuation >= 20 || puntuation <= -20)
                        {
                            break;
                        }
                    }
                }
            }
            Console.SetCursorPosition(5,20);
            Console.WriteLine("The winner is {0}!!!",
                puntuation >= 20? "Player 1":"Player 2");
            Console.ReadKey();

        }


        static void player(Object param)
        {
            int num;

            short plaNun = ((Parameters)param).playerNum;
            short posLeft = ((Parameters)param).posLeft;

            Random ram = ((Parameters)param).ram;

            while (true) {
                lock (l) {
                    num = ram.Next(1, 10);

                    Console.SetCursorPosition(posLeft, 10);
                    Console.Write(" ");
                    Thread.Sleep(50);
                    Console.SetCursorPosition(posLeft, 10);
                    Console.Write(num);
                    if (num == 5 || num == 7)
                    {
                        playerNum = plaNun;
                    }
                    isPaused = true;
                    Monitor.Wait(l);
                }
                Thread.Sleep(200 * num);
                //Thread.Sleep(5000);
            }
        }

        static void display()
        {
            int cont = 0;
            while (true)
            {
                lock (l)
                {
                    if (isBlinking) {
                        Console.SetCursorPosition(23, 10);

                        if (cont % 2 == 0) Console.BackgroundColor = ConsoleColor.DarkBlue;
                        else Console.BackgroundColor = ConsoleColor.DarkRed;

                        Console.Write("     ");

                        Console.BackgroundColor = ConsoleColor.Black;
                        cont++;
                    }
                    
                }
                Thread.Sleep(200);
                
            }
        }

        static void paint()
        {
            Console.SetCursorPosition(7, 8);
            Console.Write("Player 1");
            Console.SetCursorPosition(37, 8);
            Console.Write("Player 2");
            Console.SetCursorPosition(10, 3);
            Console.Write("Puntuación:");
        }

        static void writePuntuation()
        {
            Console.SetCursorPosition(23, 3);
            Console.Write("{0,3}", " ");
            Thread.Sleep(50);
            Console.SetCursorPosition(23, 3);
            Console.Write("{0,3}", puntuation);
        }

        private class Parameters
        {
            public Random ram;
            public short playerNum;
            public short posLeft;

            public Parameters(Random ram, short playerNum, short posLeft)
            {
                this.ram = ram;
                this.playerNum = playerNum;
                this.posLeft = posLeft;
            }
        }
    }
}

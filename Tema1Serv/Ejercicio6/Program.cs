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
        static int score = 0;
        static bool isPaused = false;
        static bool starGame = true;
        static bool isScore = false;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Random ram = new Random();

            paint();
            writePuntuation();

            Thread.Sleep(500);

            Thread player1 = new Thread(player);
            Thread player2 = new Thread(player);
            Thread threadDisplay = new Thread(display);

            player1.Start(new Parameters(ram, 1, 10));
            player2.Start(new Parameters(ram, 2, 40));
            threadDisplay.Start();

            //player1.IsBackground = true;
            //player2.IsBackground = true;
            //threadDisplay.IsBackground = true;

            

            while (true) {
                lock (l)
                {
                    if (isPaused)
                    {
                        if (playerNum == 1)
                        {
                            if (isBlinking)
                            {
                                score += 1;
                                isBlinking = false;
                            }
                            else
                            {
                                score += 5;
                            }
                            starGame = false;
                            writePuntuation();
                        }
                        if (playerNum == 2)
                        {
                            if (isBlinking)
                            {
                                if (starGame) score -= 1;
                                else score -= 5;
                            }
                            else
                            {
                                score -= 1;
                                isBlinking = true;
                            }
                            starGame = false;
                            writePuntuation();
                        }
                        playerNum = 0;
                        Monitor.Pulse(l);
                        Monitor.Pulse(l);
                        isPaused = false;


                        if (score >= 20 || score <= -20)
                        {
                            break;
                        }
                        else
                        {
                            Monitor.Wait(l);
                            isScore = false;
                        }
                    }
                }
            }
            Console.SetCursorPosition(5,20);
            Console.WriteLine("The winner is {0}!!!",
                score >= 20? "Player 1":"Player 2");
            Console.ReadKey();

        }


        static void player(Object param)
        {
            int num;

            short plaNun = ((Parameters)param).playerNum;
            short posLeft = ((Parameters)param).posLeft;

            Random ram = ((Parameters)param).ram;

            while (Math.Abs(score) < 20) {
                lock (l) {
                    num = ram.Next(1, 10);

                    Console.SetCursorPosition(posLeft, 10);
                    Console.Write(" ");
                    Thread.Sleep(50);
                    Console.SetCursorPosition(posLeft, 10);
                    Console.Write(num);
                    if (num == 5 || num == 7)
                    {
                        if (isScore)
                        {
                            Monitor.Wait(l);
                        }
                        isScore = true;
                        playerNum = plaNun;
                    }
                    isPaused = true;
                    Monitor.Pulse(l);
                    Monitor.Wait(l);
                }
                Thread.Sleep(200 * num);
                //Thread.Sleep(5000);
            }
        }

        static void display()
        {
            int cont = 0;
            while (Math.Abs(score) < 20)
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
            Console.Write("Score:");
        }

        static void writePuntuation()
        {
            Console.SetCursorPosition(23, 3);
            Console.Write("{0,3}", " ");
            Thread.Sleep(50);
            Console.SetCursorPosition(23, 3);
            Console.Write("{0,3}", score);
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

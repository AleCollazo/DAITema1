using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Servidor
    {
        static void Main(string[] args)
        {
            
            string msg;
            int puerto = 6000000;//55814;
            bool flag = true;

            IPEndPoint ie;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            do
            {
                flag = true;
                if (puerto > 65535 || puerto < 1024)
                {
                    puerto = 1024;
                }

                try
                {
                    Console.WriteLine(puerto);
                    ie = new IPEndPoint(IPAddress.Any, puerto);

                    s.Bind(ie);
                    

                    Console.WriteLine("No salta exception");
                    flag = false;
                }
                catch (SocketException)
                {
                    puerto++;
                    Console.WriteLine("Dentro");
                    
                }
            } while (flag);

            Console.WriteLine("fuera");


            s.Listen(10);

            while (true)
            {
                Socket sClient = s.Accept();

                IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;

                Console.WriteLine("Client connected: {0} at port {1}", ieClient.Address, ieClient.Port);

                NetworkStream ns = new NetworkStream(sClient);

                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);


                try
                {
                    msg = sr.ReadLine().ToUpper();

                    if (msg == "APAGAR")
                    {
                        break;
                    }

                    DateTime dateTime = DateTime.Now;

                    if (msg == "FECHA")
                    {
                        sw.WriteLine("{0}/{1}/{2}",
                            dateTime.Day, dateTime.Month, dateTime.Year);
                    }
                    if (msg == "HORA")
                    {
                        sw.WriteLine("{0}:{1}:{2}", dateTime.Hour, dateTime.Minute, dateTime.Second);
                    }
                    if (msg == "TODO")
                    {
                        sw.WriteLine("{0}/{1}/{2}   {4}:{5}:{6}",
                            dateTime.Day, dateTime.Month, dateTime.Year,
                            Environment.NewLine,
                            dateTime.Hour, dateTime.Minute, dateTime.Second);
                    }

                    sw.Flush();
                }
                catch (IOException)
                {
                    break;
                }

                Console.WriteLine("Client disconnected. \nConnection closed");

                sw.Close();
                sr.Close();

                ns.Close();

                sClient.Close();
            }

                
            s.Close();
        }
    }
}

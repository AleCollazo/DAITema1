using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            s.Bind(ie);
            s.Listen(10);

            while (true)
            {
                Socket cliente = s.Accept();
                Thread hilo = new Thread(hiloCliente);
                hilo.Start(hilo);
            }
        }

        static void hiloCliente(object socket)
        {
            int number;

            Socket clientSocket = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)clientSocket.RemoteEndPoint;

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);

            string welcome = "Welcome to the game";
            sw.WriteLine(welcome);
            sw.Flush();


            while (true)
            {

            }
        }
    }
}

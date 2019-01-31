using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace servidor
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();

        static readonly object l = new object();
        static readonly object m = new object();

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
                hilo.Start(cliente);
            }
        }

        static void enviarMsg(object msg)
        {
            string mensaje = (string)msg;
            Socket cliente;
            IPEndPoint ieCliente;

            lock (l)
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    try
                    {
                        cliente = clientes[i].Socket;
                        ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
                        try
                        {
                            NetworkStream ns = new NetworkStream(cliente);
                            StreamWriter sw = new StreamWriter(ns);
                        
                            lock (m)
                            {
                                sw.WriteLine(mensaje);
                                sw.Flush();
                            }
                        }
                        catch (IOException)
                        {
                            
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }
            }
        }

        static void hiloCliente(object socket)
        {
            string mensaje, usuario;

            Cliente cliente;
            Socket clientSocket = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)clientSocket.RemoteEndPoint;

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            string welcome = string.Format("Welcome to this great Server{0}Introduce a username:",
                Environment.NewLine);
            sw.WriteLine(welcome);
            sw.Flush();

            usuario = sr.ReadLine();

            lock (l)
            {
                cliente = new Cliente(clientSocket, usuario);
                clientes.Add(cliente);
            }

            Thread hiloConnect = new Thread(enviarMsg);
            hiloConnect.Start(string.Format("Connected user {0}@{1}:{2}",
                usuario, ieCliente.Address, ieCliente.Port));

            while (true)
            {
                try
                {
                    mensaje = sr.ReadLine();
                    if (mensaje == "#exit")
                    {
                        break;
                    }
                    if (mensaje == "#list")
                    {
                        lock (l)
                        {
                            IPEndPoint ieUsuarios;
                            lock (m) {
                                for (int i = 0; i < clientes.Count; i++)
                                {
                                    ieUsuarios = (IPEndPoint)clientes[i].Socket.RemoteEndPoint;
                                    Thread hiloLista = new Thread(enviarMsg);
                                    hiloLista.Start(string.Format("{0}@{1}:{2}",
                                        clientes[i].UserName, ieUsuarios.Address, ieUsuarios.Port));
                                }
                            }
                        }
                        continue;
                    }
                    Thread hiloMsg = new Thread(enviarMsg);
                    hiloMsg.Start(string.Format("{0}@{1} says: {2}",
                            usuario, ieCliente.Address, mensaje));
                }
                catch (IOException)
                {
                    break;
                }
            }
            Thread hiloFinish = new Thread(enviarMsg);
            hiloFinish.Start(string.Format("Finished connection of {0}@{1}:{2}",
                usuario, ieCliente.Address, ieCliente.Port));

            lock (l)
            {
                clientes.Remove(cliente);
            }

            sw.Close();
            sr.Close();
            ns.Close();
            clientSocket.Close();
        }
    }

    class Cliente
    {
        public Socket Socket { get; }
        public string UserName { get; }

        public Cliente(Socket socket, string userName)
        {
            Socket = socket;
            UserName = userName;
        }
    }
}

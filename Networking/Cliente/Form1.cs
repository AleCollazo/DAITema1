using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        string IpServer = "127.0.0.1";
        int puerto = 31416;
        string msg;
        IPEndPoint ie;
        Socket server;

        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            ie = new IPEndPoint(IPAddress.Parse(IpServer), puerto);
        }

        private void cliente(string userMsg)
        {

            try
            {
                conectarse(ie);
                sw.WriteLine(userMsg);
                sw.Flush();
                lbl.Text = sr.ReadLine();
                cerrarConexion();
            }
            catch (IOException)
            {
                lbl.Text = "Servidor apagado";
            }
            catch (ObjectDisposedException)
            {
               lbl.Text = "Dirección no disponible";
            }
            catch (NullReferenceException)
            {
                lbl.Text = "Error";
            }
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            
            cliente("HORA");
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            cliente("FECHA");
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            cliente("TODO");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            cliente("APAGAR");
        }


        private void btnCambiarIp_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            DialogResult result = form2.ShowDialog();
            if (DialogResult.OK == result) {
                ie = form2.getIPEndPoint();
                
            }
        }

        private void cerrarConexion()
        {
            sw.Close();
            sr.Close();
            ns.Close();
            server.Close();
        }

        private void conectarse(IPEndPoint ie)
        {
            
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ie);
            }
            catch (SocketException ex)
            {
                lbl.Text = string.Format("Error connection: {0}{3}Error code {1}({2})", ex.Message, (SocketError)ex.ErrorCode, ex.ErrorCode, Environment.NewLine);
                return;
            }

            ns = new NetworkStream(server);
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);

            
        }
    }
}

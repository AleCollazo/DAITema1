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
        const string IP_SERVER = "127.0.0.1";
        string msg;
        IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_SERVER),31416);
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void cliente(string userMsg)
        {

            try
            {
                sw.WriteLine(userMsg);
                sw.Flush();
                lbl.Text = sr.ReadLine();
            }
            catch (IOException)
            {
                lbl.Text = "Servidor apagado";
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

        private void Form1_Load(object sender, EventArgs e)
        {
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

            msg = sr.ReadLine();
            lbl.Text = msg;
        }

        private void btnCambiarIp_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.ShowDialog();


        }
    }
}

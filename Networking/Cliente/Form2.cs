using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form2 : Form
    {
        private bool errorIP, errorPuerto;
        private IPEndPoint ie;

        public Form2()
        {
            InitializeComponent();
        }

        public IPEndPoint getIPEndPoint()
        {
            return ie;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorIP = false;
            errorPuerto = false;
            int puerto = 0;

            try
            {
                puerto = Convert.ToInt32(tbxPuerto.Text);
            }
            catch (FormatException)
            {
                errorPuerto = true;
            }
            catch (OverflowException)
            {
                errorPuerto = true;
            }

            try
            {
                ie = new IPEndPoint(IPAddress.Parse(tbxIp.Text), puerto);
            }
            catch (ArgumentNullException)
            {
                errorIP = true;
            }
            catch (FormatException)
            {
                errorIP = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                errorPuerto = true;
            }

            if (errorIP)
            {
                MessageBox.Show("IP no válida", "IP introducida no es válida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (errorPuerto)
            {
                MessageBox.Show("Puerto no válido", "Puerto introducido no es válido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (errorIP || errorPuerto)
            {
                e.Cancel = true;
                errorIP = false;
                errorPuerto = false;
            }
        }
    }
}

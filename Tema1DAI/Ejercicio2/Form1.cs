#define teclaChar

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private string titulo = "Mouse Tester";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = string.Format("{2}  Eje x: {0}  Eje y: {1}", e.X, e.Y, titulo);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}", titulo);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto = ((Button)sender).Location;
            this.Text = string.Format("{2}  Eje x: {0}  Eje y: {1}", punto.X + e.X, punto.Y + e.Y, titulo);
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            btnDerecho.BackColor = DefaultBackColor;
            btnIzquierdo.BackColor = DefaultBackColor;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right.Equals(e.Button))
            {
                btnDerecho.BackColor = Color.BlueViolet;
            }
            if (MouseButtons.Left.Equals(e.Button))
            {
                btnIzquierdo.BackColor = Color.BlueViolet;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto = ((Button)sender).Location;
            this.Text = string.Format("{2}  Eje x: {0}  Eje y: {1}", punto.X + e.X, punto.Y + e.Y, titulo);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)== DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

#if teclaChar
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = e.KeyChar.ToString();
        }

#else
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Escape.Equals(e.KeyCode))
            {
                this.Text = titulo;
            }
            else {
                this.Text = e.KeyCode.ToString();
            }
        }
#endif
    }
}

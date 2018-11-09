using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void cambioColorFondo()
        {
            int[] numsColor = { 255, 255, 255 };

            //bool valido = true;

            try
            {
                numsColor[0] = Convert.ToInt32(txtRojo.Text);
                numsColor[1] = Convert.ToInt32(txtAmarillo.Text);
                numsColor[2] = Convert.ToInt32(txtAzul.Text);
                this.BackgroundImage = null;
                this.BackColor = Color.FromArgb(numsColor[0], numsColor[1], numsColor[2]);
            }
            catch (FormatException) { MessageBox.Show("Introduce valores numéricos", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //catch (OverflowException) { }
            catch (ArgumentException) { MessageBox.Show("Introduce valores entre 0 y 255", "Fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //for (int i = 0; i < 3; i++)
            //{
            //    if (numsColor[i] < 0 || numsColor[i] > 255)
            //    {
            //        valido = false;
            //    }
            //}

            //if (valido)
            //{
            //    this.BackColor = Color.FromArgb(numsColor[0], numsColor[1], numsColor[2]);

            //}
            //else
            //{
            //    MessageBox.Show("Introduce valores entre 0 y 255", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = new Bitmap(txtPath.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Campo introducido no válido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("No tiene el permiso de acceso", "Sin permiso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Documento no válido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.cambioColorFondo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi aplicación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void salirCambioRGB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cambioColorFondo();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

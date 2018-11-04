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

        

        
        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = new Bitmap(txtPath.Text);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int[] numsColor = { 255, 255, 255 };

            bool valido = true;
            
            try
            {
                numsColor[0] = Convert.ToInt32(txtRojo.Text);
                numsColor[1] = Convert.ToInt32(txtAmarillo.Text);
                numsColor[2] = Convert.ToInt32(txtAzul.Text);
            }
            catch (FormatException) { }
            catch (OverflowException) { }

            for (int i = 0; i < 3; i++) {
                if (numsColor[i] < 0 || numsColor[i] > 255)
                {
                    valido = false;
                }
            }

            if (valido) {
                this.BackColor = Color.FromArgb(numsColor[0], numsColor[1], numsColor[2]);
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi aplicación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                ==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnImg_DragEnter(object sender, DragEventArgs e)
        {
            
        }
    }
}

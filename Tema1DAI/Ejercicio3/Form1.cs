using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir",
                "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            try
            {
                Image img = new Bitmap(tbxPath.Text);
                form.ClientSize = img.Size;
                form.BackgroundImage = img;
                if (cbxModal.Checked)
                {
                    form.ShowDialog();
                }
                else
                {
                    form.Show();
                }
            }
            catch (System.IO.FileNotFoundException)
            {

            }
            catch (ArgumentException){ }
        }

        public string getPathImagen()
        {
            return tbxPath.Text;
        }
    }
}

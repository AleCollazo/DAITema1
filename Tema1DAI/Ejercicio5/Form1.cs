using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        private int tbxHeightInit;
        private int tbxWidthInit;

        private int formHeightMin;
        private int formWidthMin;

        private bool init = false;

        private static TextBox texBoxForm1;

        public Form1()
        {
            InitializeComponent();
            init = true;
            tbxHeightInit = tbx.Height;
            tbxWidthInit = tbx.Width;
            formHeightMin = this.Height;
            formWidthMin = this.Width;
            texBoxForm1 = tbx;
        }

        private void cambioFamiliaFuente(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            tbx.Font = new Font(rbt.Text, (int)rbt.Tag);
        }

        private void cambioColorFuente(object sender, EventArgs e)
        {
            if (!cbxInvertirColor.Checked) {
                RadioButton rbt = (RadioButton)sender;
                tbx.ForeColor = rbt.BackColor;
            }
            else
            {
                RadioButton rbt = (RadioButton)sender;
                tbx.BackColor = rbt.BackColor;
                gbxColorFuente.Text = "";
            }
        }

        private void cambioColorFondo(object sender, EventArgs e)
        {
            if (!cbxInvertirColor.Checked) {
                RadioButton rbt = (RadioButton)sender;
                tbx.BackColor = rbt.BackColor;
            }
            else
            {
                RadioButton rbt = (RadioButton)sender;
                tbx.ForeColor = rbt.BackColor;
            }
        }

        private void cbxColor_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                gbxColorFondo.Enabled = true;
                gbxColorFuente.Enabled = true;
                cbxInvertirColor.Enabled = true;
            }
            else
            {
                gbxColorFondo.Enabled = false;
                gbxColorFuente.Enabled = false;
                cbxInvertirColor.Enabled = false;
            }
        }

        private void cbxInvertirColor_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {
                gbxColorFondo.Text = "Color de fuente";
                gbxColorFuente.Text = "Color de fondo";
            }
            else
            {
                gbxColorFondo.Text = "Color de fondo";
                gbxColorFuente.Text = "Color de fuente";
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (init) {
                tbx.Height = tbxHeightInit + (this.Height - formHeightMin);
                tbx.Width = tbxWidthInit + (this.Width - formWidthMin);
            }
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

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        public static void modificarSeleccion(int inicio, int longitud)
        {
            try
            {
                texBoxForm1.SelectionStart = inicio;
                texBoxForm1.SelectionLength = longitud;
                texBoxForm1.Focus();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Valores inválidos. No se corresponde con la longitude del texto.", 
                                "Fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int getInicioSeleccion()
        {
            return texBoxForm1.SelectionStart;
        }

        public static int getLongitudSeleccion()
        {
            return texBoxForm1.SelectionLength;
        }

    }
}

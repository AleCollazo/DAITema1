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
        public Form1()
        {
            InitializeComponent();
        }

        private void CambioFamiliaFuente(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            tbx.Font = new System.Drawing.Font(rbt.Text, (int)rbt.Tag);
        }

        private void CambioColor(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            tbx.ForeColor = rbt.BackColor;
        }
    }
}

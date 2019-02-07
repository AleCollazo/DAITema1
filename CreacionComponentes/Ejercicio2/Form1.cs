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
        public Form1()
        {
            InitializeComponent();
        }

        private void etiquetaAviso1_ClickMarca(object sender, EventArgs e)
        {
            Console.WriteLine("Puslsada la Marca");
        }

        private void etiquetaAviso1_Click(object sender, EventArgs e)
        {
            Console.Write("Puslsada Click");
        }

    }
}

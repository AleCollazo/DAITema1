﻿using System;
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
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inicioSeleccion = 0, longitudSeleccion = 0;

            try
            {
                inicioSeleccion = Convert.ToInt32(tbxInicio.Text);
                longitudSeleccion = Convert.ToInt32(tbxSeleccion.Text);
            }
            catch (FormatException) { MessageBox.Show("Introduce valores numéricos enteros.", "Valor numérico", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (OverflowException) {  }

            form1.modificarSeleccion(inicioSeleccion, longitudSeleccion);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbxInicio.Text = form1.getInicioSeleccion().ToString();
            tbxSeleccion.Text = form1.getLongitudSeleccion().ToString();
        }
    }
}

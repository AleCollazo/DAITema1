using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    delegate double? operacion(double num1, double num2);

    

    public partial class Form1 : Form
    {
        private Hashtable htbOperacion = new Hashtable();
        private operacion opSuma = new operacion(suma);
        private operacion opResta = new operacion(resta);
        private operacion opMultiplicacion = new operacion(multiplicacion);
        private operacion opDivision = new operacion(division);

        string operacionSeleccionada = "Suma";

        public Form1()
        {
            InitializeComponent();
            htbOperacion.Add("Suma", opSuma);
            htbOperacion.Add("Resta", opResta);
            htbOperacion.Add("Multiplicación", opMultiplicacion);
            htbOperacion.Add("División", opDivision);
        }

        public static double? suma(double num1, double num2) { return num1 + num2; }
        public static double? resta(double num1, double num2) { return num1 - num2; }
        public static double? multiplicacion(double num1, double num2) { return num1 * num2; }
        public static double? division(double num1, double num2)
        {
            if (num2 == 0)
            {
                return null;
            }
            return num1 / num2;
        }

        
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(tbxNum1.Text);
                double num2 = Convert.ToDouble(tbxNum2.Text);

                double? resultado = ((operacion)htbOperacion[operacionSeleccionada])(num1, num2);

                lblResultado.Text = string.Format("{0}", resultado);
            }
            catch (FormatException) { MessageBox.Show("Formato del campo inválido", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (OverflowException) {  }
        }

        private void cambiarOperacion(object sender, EventArgs e)
        {
            lblOperador.Text = (string)((RadioButton)sender).Tag;
            operacionSeleccionada = ((RadioButton)sender).Text;
        }

       
    }
}

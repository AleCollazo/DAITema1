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
    delegate int? operacion(int num1, int num2);

    

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

        public static int? suma(int num1, int num2) { return num1 + num2; }
        public static int? resta(int num1, int num2) { return num1 - num2; }
        public static int? multiplicacion(int num1, int num2) { return num1 * num2; }
        public static int? division(int num1, int num2)
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
                int num1 = Convert.ToInt32(tbxNum1.Text);
                int num2 = Convert.ToInt32(tbxNum2.Text);

                int? resultado = ((operacion)htbOperacion[operacionSeleccionada])(num1, num2);

                lblResultado.Text = string.Format("= {0}", resultado);
            }
            catch (FormatException) { lblResultado.Text = "Formato del campo inválido"; }
            catch (OverflowException) { lblResultado.Text = "Número demasiado grande"; }
        }

        private void cambiarOperacion(object sender, EventArgs e)
        {
            lblOperador.Text = (string)((RadioButton)sender).Tag;
            operacionSeleccionada = (string)((RadioButton)sender).Text;
        }

       
    }
}

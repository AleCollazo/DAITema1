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
    delegate int operacion(int num1, int num2);

    

    public partial class Form1 : Form
    {
        Hashtable htbOperacion = new Hashtable();
        operacion opSuma = new operacion(suma);
        operacion opResta = new operacion(suma);
        operacion opMultiplicacion = new operacion(suma);
        operacion opDivision = new operacion(suma);


        public Form1()
        {
            InitializeComponent();
            htbOperacion.Add("Suma", opSuma);
            htbOperacion.Add("Resta", opResta);
            htbOperacion.Add("Multiplicación", opMultiplicacion);
            htbOperacion.Add("División", opDivision);
        }

        public static int suma(int num1, int num2) { return num1 + num2; }
        public static int resta(int num1, int num2) { return num1 - num2; }
        public static int multiplicacion(int num1, int num2) { return num1 * num2; }
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
            lblResultado.Text = ((operacion)htbOperacion[new Form1().checkedRadioButton()])(1,2).ToString();
        }

        private string checkedRadioButton()
        {
            RadioButton[] rbts = { rbtSuma, rbtResta, rbtMultiplicación, rbtDivision};

            string seleccion = "";

            foreach (RadioButton rbt in rbts)
            {
                if (rbt.Checked)
                {
                    seleccion = rbt.Text;
                    lblOperador.Text = (string)rbt.Tag;
                }
            }

            return seleccion;
        }
    }
}

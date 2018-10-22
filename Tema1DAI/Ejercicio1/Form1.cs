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

        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("{0}  -  {1}", e.KeyCode, Keys.Enter);
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("Se pulsó enter");
                if (((TextBox)sender).Name == txtPath.Name)
                {
                    try
                    {
                        this.Icon = new Icon(txtPath.Text);
                        Console.WriteLine("Entró");
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
            }
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

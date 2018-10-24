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

            for (int i = 0; i < 3; i++) {
                try
                {
                    numsColor[i] = Convert.ToInt32(txt.Text);
                }
                catch (FormatException) { }
                catch (OverflowException) { }

                if (numsColor[i] >= 0 && numsColor[i] <= 255)
                {
                    
                }
            }
            this.BackColor = Color.FromArgb(numsColor[0], numsColor[1], numsColor[2]);
        }
    }
}

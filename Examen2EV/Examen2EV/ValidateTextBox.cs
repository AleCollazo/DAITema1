using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2EV
{
    public enum eTipo
    {
        Numerico,
        Textual
    }

    public partial class ValidateTextBox : UserControl
    {
        private Color colorRect;

        public ValidateTextBox()
        {
            InitializeComponent();

            colorRect = Color.Red;
        }

        [Category("Aparencia")]
        [Description("Acede y modifica la propieda Text del TextBox")]
        public string Texto
        {
            get
            {
                return tbx.Text;
            }
            set
            {
                tbx.Text = value;
            }
        }

        [Category("Comportamiento")]
        [Description("Controla TextBox puede abarcar varias línias")]
        public bool Multilinea
        {
            get
            {
                return tbx.Multiline;
            }
            set
            {
                tbx.Multiline = value;
            }
        }

        private eTipo tipo = eTipo.Textual;
        [Category("Aparencia")]
        [Description("Indica el tipo de datos que se introduce en el TextBox")]
        public eTipo Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Size = new Size(tbx.Size.Width+20, tbx.Size.Height +20);

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(colorRect)), 5,5,5,5);
        }

        private void comprobar()
        {
            if (Tipo == eTipo.Numerico)
            {
                try
                {
                    string num = Texto.Trim();
                    Convert.ToInt32(num);
                    colorRect = Color.Green;
                }
                catch (FormatException)
                {
                    colorRect = Color.Red;
                }
                catch (OverflowException)
                {
                    colorRect = Color.Red;
                }
            }
            else
            {

            }
        }


    }
}

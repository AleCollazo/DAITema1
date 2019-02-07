using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class EtiquetaAviso : Control
    {
        public enum eMarca
        {
            Nada,
            Cruz,
            Circulo
        }
        [Category("Aparencia")]
        [Description("Se activa un gradiente de color al fondo de la etiqueta")]
        private bool conGradiente = false;
        public bool ConGradiente
        {
            set
            {
                ConGradiente = value;
                this.Refresh();
            }
            get
            {
                return conGradiente;
            }
        }

        [Category("Aparencia")]
        [Description("Colaca la marca seleccionada antes del texto")]
        private eMarca marca = eMarca.Nada;
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height, this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    lapiz.Dispose();
                    break;
            }

            LinearGradientBrush c = new LinearGradientBrush(
              new PointF(0f, 0f), new PointF(2f, 5f), this.ForeColor, Color.White);
            g.DrawRectangle(new Pen(c), 0, 0, this.Width, this.Height);

            SolidBrush b = new SolidBrush(this.ForeColor);
            //LinearGradientBrush c = new LinearGradientBrush(
            //  new PointF(0f,0f), new PointF(2f,5f), this.ForeColor, Color.White);
            g.DrawString(this.Text, this.Font, b, offsetX, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);

            

            b.Dispose();
            c.Dispose();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        
    }
}

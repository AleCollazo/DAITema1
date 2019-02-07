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

namespace Ejercicio2
{
    public partial class EtiquetaAviso : Control
    {
        private int offsetX;
        private int offsetY;
        private int grosor;

        public enum eMarca
        {
            Nada,
            Cruz,
            Circulo,
            ImagenMarca
        }

        public EtiquetaAviso()
        {
            InitializeComponent();
            Color1 = Color.LightBlue;
            Color2 = Color.LemonChiffon;
            IsGradiente = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            grosor = 0;
            offsetX = 0;
            offsetY = 0;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    break;
                case eMarca.ImagenMarca:  
                    if (ImagenMarca != null)
                    {
                        grosor = 10;
                        offsetX = this.Font.Height + grosor;
                        offsetY = grosor /2;
                    }
                    break;
            }


            
            SolidBrush b = new SolidBrush(this.ForeColor);
            
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);

            if (IsGradiente) {
                LinearGradientBrush lgb = new LinearGradientBrush(new Point(0, 0), new Point(this.Width, this.Height), Color1, Color2);
                g.DrawLine(new Pen(lgb, this.Height * 2), 0, 0, this.Width, 0);
                lgb.Dispose();
            }
            else
            {
                SolidBrush lgb = new SolidBrush(Color1);
                g.DrawLine(new Pen(lgb, this.Height * 2), 0, 0, this.Width, 0);
                lgb.Dispose();
            }

            switch (Marca)
            {
                case eMarca.Circulo:
                    
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                        this.Font.Height, this.Font.Height);
                    
                    break;
                case eMarca.Cruz:
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height, this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor, this.Font.Height);
                    lapiz.Dispose();
                    break;
                case eMarca.ImagenMarca:
                    if (ImagenMarca != null)
                    {
                        g.DrawImage(ImagenMarca, new Rectangle(0, 0, this.Font.Height + grosor, this.Font.Height + grosor));  
                    }
                    break;
            }

            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);

            b.Dispose();
            
            
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X <= offsetX + grosor)
            {
                ClickMarca?.Invoke(this, e);
            }
        }
        


        private Color color1;
        [Category("Apariencia")]
        [Description("Selecciona el primer color para el gradiente del fondo.")]
        public Color Color1
        {
            set
            {
                color1 = value;
                this.Refresh();
            }
            get
            {
                return color1;
            }
        }

        private Color color2;
        [Category("Apariencia")]
        [Description("Selecciona el segundo color para el gradiente del fondo.")]
        public Color Color2
        {
            set
            {
                color2 = value;
                this.Refresh();
            }
            get
            {
                return color2;
            }
        }

        private bool isGradient;
        [Category("Apariencia")]
        [Description("Indica si el fondo tiene un gradiente de color o es de un color.")]
        public bool IsGradiente
        {
            set
            {
                isGradient = value;
                this.Refresh();
            }
            get
            {
                return isGradient;
            }
        }

       
        private eMarca marca = eMarca.Nada;
        [Category("Apariencia")]
        [Description("Selecciona el tipo de marca para la etiqueta.")]
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

        private Image imagenMarca;
        [Category("Apariencia")]
        [Description("Selecciona una imagen como marca.")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }

        [Category("Acción")]
        [Description("Se lanza cuando se hace un click en la marca")]
        public event EventHandler ClickMarca;



    }
}

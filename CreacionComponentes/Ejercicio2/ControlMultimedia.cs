using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Ejercicio2
{
    public partial class ControlMultimedia : UserControl
    {

        private Image imgPlay, imgPause;
        private int imgHeight = 70, imgWidth = 70, margin = 10;
        private int cont = 0;

        private int textLblTiempoXX = 0;
        [Category("Appearence")]
        [Description("Texto asociado a XX de la Label")]
        public int TextLblTiempoXX
        {
            set
            {
                if (value > 99)
                {
                    textLblTiempoXX = 0;
                }
                else
                {
                    textLblTiempoXX = value;
                }
                lblTiempo.Text = string.Format("{0}:{1}",
                    textLblTiempoXX,textLblTiempoYY);
            }
            get
            {
                return textLblTiempoXX;
            }
        }

        private int textLblTiempoYY = 0;
        [Category("Appearence")]
        [Description("Texto asociado a YY de la Label")]
        public int TextLblTiempoYY
        {
            set
            {
                if (value >= 60)
                {
                    DesbordaTiempo?.Invoke(this, new EventArgs());
                }
                textLblTiempoYY = value % 60;
                lblTiempo.Text = string.Format("{0}:{1}",
                    textLblTiempoXX, textLblTiempoYY);  
            }
            get
            {
                return textLblTiempoYY;
            }
        }

       
        public ControlMultimedia()
        {
            InitializeComponent();
            btn.Size = new Size(imgWidth, imgHeight);

            imgPlay = Properties.Resources.play;
            imgPlay = new Bitmap(imgPlay, imgWidth, imgHeight);
            btn.Image = imgPlay;


            imgPause = Properties.Resources.pause;
            imgPause = new Bitmap(imgPause, imgWidth, imgHeight);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            PulsacionEventArgs pulsacionesArgs = new PulsacionEventArgs();

            cont++;
            if (cont % 2 == 0)
            {
                btn.Image = imgPlay;
                pulsacionesArgs.play = false;
            }
            else
            {
                btn.Image = imgPause;
                pulsacionesArgs.play = true;
            }

            Pulsacion?.Invoke(this, pulsacionesArgs);
            Refresh();
        }

        public event EventHandler DesbordaTiempo;
        public event EventHandler<PulsacionEventArgs> Pulsacion;


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.Size = new Size(
                 btn.Image.Width + 2 * margin,
                lblTiempo.Height + btn.Image.Height + 3 * margin);


            lblTiempo.Location = new Point((this.Size.Width - lblTiempo.Width) / 2, margin);

            btn.Location = new Point((this.Size.Width - btn.Width)/2, lblTiempo.Height + 2*margin);

        }

    }

    public class PulsacionEventArgs : EventArgs
    {
        public bool play;
    }


}

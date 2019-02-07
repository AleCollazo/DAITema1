using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class ControlMultimedia : UserControl
    {


        private int textLblTiempoXX = 0;
        [Category("Appearence")]
        [Description("Texto asociado a XX de la Label")]
        public int TextLblTiempoXX
        {
            set
            {
                

            }
            get
            {
                return 0;
            }
        }

        private int textLblTiempoYY = 0;
        [Category("Appearence")]
        [Description("Texto asociado a YY de la Label")]
        public int TextLblTiempoYY
        {
            set
            {

            }
            get
            {
                return 0;
            }
        }
        
        

        public ControlMultimedia()
        {
            InitializeComponent();
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private DirectoryInfo directoryInfo;
        private string directoryName;
        private FileInfo[] files;
        private List<FileInfo> imageFiles = new List<FileInfo>();
        private int cont;

        public Form1()
        {
            InitializeComponent();
        }

        private void obtenerArchivosImagenes()
        {

            try
            {
                files = directoryInfo.GetFiles();

                string filesNameAux;

                for (int i = 0; i < files.Length; i++)
                {
                    filesNameAux = files[i].Name;
                    if (filesNameAux.Substring(filesNameAux.Length - 4, 4) == ".jpg" ||
                        filesNameAux.Substring(filesNameAux.Length - 4, 4) == ".png" ||
                        filesNameAux.Substring(filesNameAux.Length - 5, 5) == ".jpeg")
                    {
                        imageFiles.Add(files[i]);
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont >= imageFiles.Count)
            {
                cont = 0;
            }
            Image image = new Bitmap(imageFiles[cont].FullName);
            pbx.Image = image;
            pbx.Size = image.Size;
            //this.Size = new Size(200 + image.Width, image.Height> 500? image.Height+ 100:500);
            controlMultimedia.TextLblTiempoYY++;
        }

        private void mensajeError(string exceptionTxt)
        {
            MessageBox.Show(exceptionTxt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void controlMultimedia_DesbordaTiempo(object sender, EventArgs e)
        {
            controlMultimedia.TextLblTiempoXX++;
        }

        private void controlMultimedia_Pulsacion(object sender, PulsacionEventArgs e)
        {
            try
            {
                directoryName = tbxDir.Text;
                if (directoryName != "")
                {
                    if (e.play)
                    {
                        directoryInfo = new DirectoryInfo(directoryName);
                        obtenerArchivosImagenes();
                        timer.Start();
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
            }
            catch (ArgumentException ex) { mensajeError(ex.Message); }
            catch (System.Security.SecurityException ex) { mensajeError(ex.Message); }
            catch (PathTooLongException ex) { mensajeError(ex.Message); }
            catch (DirectoryNotFoundException ex) { mensajeError(ex.Message); }
        }
    }
}

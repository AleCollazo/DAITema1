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

namespace Servicios2
{
    public partial class Form1 : Form
    {
        private string directoryName = "C:", strAux;
        private DirectoryInfo[] directoriesArray;
        private FileInfo[] filesArray;
        private DirectoryInfo DInfo;
 
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            if (txtDirectorio.Text.Length != 0) { 
                strAux = txtDirectorio.Text;
                txtDirectories.Text = "";
                txtFiles.Text = "";
                if (strAux.Substring(0, 1) == "%" &&
                    strAux.Substring(strAux.Length - 1, 1) == "%")
                {
                    directoryName = Environment.GetEnvironmentVariable(strAux.Substring(1, strAux.Length - 2));
                }
                else
                {
                    directoryName = strAux;
                }

                try
                {
                    Directory.SetCurrentDirectory(directoryName);
                    DInfo = new DirectoryInfo(directoryName);
                    directoriesArray = DInfo.GetDirectories();
                    filesArray = DInfo.GetFiles();

                    for (int i = 0; i < directoriesArray.Length; i++)
                    {
                        txtDirectories.Text += directoriesArray[i].Name + Environment.NewLine;
                    }

                    for (int i = 0; i < filesArray.Length; i++)
                    {
                        txtFiles.Text += filesArray[i].Name + Environment.NewLine;
                    }
                    lblError.Text = "";
                }
                catch (DirectoryNotFoundException)
                {
                    lblError.Text = "Invalid directory";
                }
                catch (IOException)
                {
                    lblError.Text = "Invalid directory";
                }
                catch (ArgumentException)
                {
                    lblError.Text = "Invalid directory";
                }
                catch (System.Security.SecurityException)
                {
                    lblError.Text = "Security problem";
                }
                catch (UnauthorizedAccessException)
                {
                    lblError.Text = "Unauthorized Access";
                }
            }
        }
    }
}

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
        private string openFile;
        private bool modified = false;
        private bool abrir = true;
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void saveFile()
        {
            DialogResult res = MessageBox.Show("Do you want to save the changes?", "Save file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (res)
            {
                case DialogResult.Yes:
                    btnSave.PerformClick();
                    txt.Text = "";
                    modified = false;
                    break;
                case DialogResult.No:
                    modified = false;
                    txt.Text = "";
                    break;
                case DialogResult.Cancel:
                    abrir = false;
                    break;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (modified)
            {
                saveFile();

            }
            else
            {
                txt.Text = "";
                modified = false;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Select directory where to save this file";
            saveFileDialog.InitialDirectory = "C:\\";
            saveFileDialog.Filter = "texto (*.txt) |*.txt|pascal (*.pas)|*.pass|visual basic (*.vb)|*vb|Todos los archivos|*.*";
            saveFileDialog.ValidateNames = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                try
                {
                    sw.Write(txt.Text);
                    modified = false;
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select file to open";
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "texto (*.txt) |*.txt|pascal (*.pas)|*.pass|visual basic (*.vb)|*vb|Todos los archivos|*.*";
            openFileDialog.RestoreDirectory = true;

            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                abrir = true;
                if (modified)
                {
                    saveFile();
                }
                if (abrir) {
                    openFile = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();
                    StreamReader sr = new StreamReader(fileStream);

                    try
                    {
                        txt.Text = sr.ReadToEnd();
                    }
                    finally
                    {
                        sr.Close();
                    }

                    modified = false;
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            modified = true;
        }

        private void openForm2(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                Form2 form2 = new Form2();
                DialogResult res = form2.ShowDialog();

                switch (res)
                {
                    case DialogResult.OK:
                        try
                        {
                            int[] colors = {Convert.ToInt32(form2.tbxRed.Text),
                                             Convert.ToInt32(form2.tbxGreen.Text),
                                             Convert.ToInt32(form2.tbxBlue.Text)};
                            Color color = Color.FromArgb(Convert.ToInt32(form2.tbxRed.Text),
                                             Convert.ToInt32(form2.tbxGreen.Text),
                                             Convert.ToInt32(form2.tbxBlue.Text));

                            txt.ForeColor = color;
                            //for (int i = 0; i < colors.Length; i++)
                            //{
                            //    if (colors[i] < 0 || colors[i] > 255)
                            //    {
                            //        throw new OutRangeException();
                            //    }
                            //}
                        }
                        catch (FormatException)
                        {
                            
                            //MessageBox.Show("");
                        }
                        catch (OutRangeException)
                        {
                            
                        }
                        
                        break;
                    case DialogResult.Cancel:
                        //form2.Close();
                        break;
                }
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryWriter bw;
            
        }
    }
}

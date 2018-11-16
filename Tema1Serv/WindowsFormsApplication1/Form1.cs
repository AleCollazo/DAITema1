using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            const string FORMAT = "{0,7}  {1,20}  {2,10}\r\n";
            tbxInfo.Text = string.Format(FORMAT, "PID", "Name", "Título");

            foreach (Process p in processes)
            {
                tbxInfo.Text += string.Format(FORMAT,
                    p.Id,
                    p.ProcessName.Length > 20 ? p.ProcessName.Substring(0, 20): p.ProcessName, 
                    p.MainWindowTitle.Length > 10 ? p.MainWindowTitle.Substring(0,10) : p.MainWindowTitle);

            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

            try
            {
                Process process = Process.GetProcessById(Convert.ToInt32(tbxPID.Text));

                ProcessModuleCollection modules = process.Modules;
                ProcessThreadCollection threads = process.Threads;

                tbxInfo.Text += string.Format("{0} \r\n", "Process:");
                const string FORMAT_PROCESS = "{0,7}  {1,20}  {2,10}\r\n";
                tbxInfo.Text = string.Format(FORMAT_PROCESS, "PID", "Name", "Título");
                tbxInfo.Text += string.Format(FORMAT_PROCESS,
                    process.Id,
                    process.ProcessName.Length > 20 ? process.ProcessName.Substring(0, 20) : process.ProcessName,
                    process.MainWindowTitle.Length > 10 ? process.MainWindowTitle.Substring(0, 10) : process.MainWindowTitle);

                const string FORMAT_THREAD = "{0,7}   {1,15}\r\n";
                tbxInfo.Text += string.Format("{0} \r\n", "Threads:");
                foreach (ProcessThread t in threads)
                {
                    tbxInfo.Text += string.Format(FORMAT_THREAD, t.Id, t.StartTime);
                }

                const string FORMAT_MODULE = "{0,20}   {1,20}\r\n";
                tbxInfo.Text += string.Format("{0} \r\n", "Modules:");
                foreach (ProcessModule m in modules)
                {
                    tbxInfo.Text += string.Format(FORMAT_MODULE,
                       m.ModuleName.Length > 20 ? m.ModuleName.Substring(0, 20) : m.ModuleName,
                       m.FileName.Length > 20 ? m.FileName.Substring(m.FileName.Length - 20, 20) : m.FileName);
                }
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FormatException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (OverflowException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Win32Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = Process.GetProcessById(Convert.ToInt32(tbxPID.Text));
                process.CloseMainWindow();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (InvalidOperationException ex ) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FormatException ex ) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (OverflowException ex ) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Win32Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = Process.GetProcessById(Convert.ToInt32(tbxPID.Text));
                process.Kill();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FormatException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (OverflowException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Win32Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            try
            {
                string[] textIn = tbxPID.Text.Split(' ');

                if (textIn.Length == 1)
                    Process.Start(textIn[0]);

                else Process.Start(textIn[0], textIn[1]);
            }
            catch (Win32Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (ObjectDisposedException ex ) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (System.IO.FileNotFoundException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

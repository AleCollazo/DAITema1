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
            const string FORMAT = "{1,7}{0,20}{2,10}";
            Console.WriteLine(FORMAT, "PID","Name", "Título");

            foreach (Process p in processes)
            {
                Console.WriteLine(FORMAT, p.ProcessName, p.Id, p.MainWindowTitle);
            }
        }
    }
}

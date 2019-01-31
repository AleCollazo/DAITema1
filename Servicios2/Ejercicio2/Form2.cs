using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {
        private string dataWrited;
        private char[] dataChars;
        private int beforeLength;
        private int cursorPosition;
        //private char numberChar;
        //TODO cuando no se meten valores
        public Form2()
        {
            InitializeComponent();
        }

        public void tbx_PressKey(object sender, EventArgs e)
        {
            Console.WriteLine();
            dataWrited = ((TextBox)sender).Text;
            if (dataWrited.Length != beforeLength)
            {
                cursorPosition = ((TextBox)sender).SelectionStart;
                //dataChars = dataWrited.ToCharArray();

                for (int i = dataWrited.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine("Writed Inicio:"+dataWrited);
                    if (dataWrited[i] >= '0' && dataWrited[i] <= '9')
                    {
                        Console.WriteLine("if isNúmero: "+ (dataWrited[i] > '0' && dataWrited[i] < '9'));
                        if (i == 0)
                        {
                            Console.WriteLine("i==0 // mayor de 2: número: "+ Convert.ToInt16(dataWrited[0].ToString()));
                            if (Convert.ToInt16(dataWrited[0].ToString()) > 2)
                            {
                                dataWrited = dataWrited.Remove(i, 1);
                                cursorPosition--;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("i!=0 // mayor de 5: número: " + Convert.ToInt16(dataWrited[i]));

                            if (Convert.ToInt16(dataWrited[i].ToString()) > 5 && ((i == 1 && dataWrited[0] == '2') || (i == 2 && dataWrited[0] =='2' && dataWrited[1] == '5')))
                            {
                                dataWrited = dataWrited.Remove(i, 1);
                                cursorPosition--;
                            }
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Else");
                        dataWrited = dataWrited.Remove(i, 1);
                        cursorPosition--;
                    }
                }
                Console.WriteLine("Writed Final: "+dataWrited);
                ((TextBox)sender).Text = dataWrited;
                beforeLength = dataWrited.Length;
                ((TextBox)sender).SelectionStart = cursorPosition;
            }

        //    Console.WriteLine();
        //    numberWrited = ((TextBox)sender).Text;

        //    Console.WriteLine("Number: "+numberWrited);
        //    Console.WriteLine("Length number: "+numberWrited.Length);

            
        //    if (numberWrited.Length > 0) {
        //        numberChar = numberWrited[numberWrited.Length - 1];

        //        Console.WriteLine("Char Number: "+numberChar);
        //        Console.WriteLine("Condición: "+ (numberChar < '0' || numberChar > '9'));
        //        if (numberChar < '0' || numberChar > '9')
        //        {

        //            ((TextBox)sender).Text = numberWrited.Substring(0, numberWrited.Length - 1);
        //            ((TextBox)sender).SelectionStart = numberWrited.Length;
        //            Console.WriteLine("Limpiar");
        //        }
        //        else { 
        //            for (int i = 0; i < numberWrited.Length; i++)
        //            {
        //                if (i == 0)
        //                {
        //                    if (Convert.ToInt16(numberWrited[0]) > 2)
        //                    {
        //                        ((TextBox)sender).Text = numberWrited.Substring(0, 1);
        //                        ((TextBox)sender).SelectionStart = 1;
        //                    }
        //                }
        //                else
        //                {
        //                    if (Convert.ToInt16(numberWrited[i]) > 5)
        //                    {
        //                        ((TextBox)sender).Text = numberWrited.Substring(0, numberWrited.Length - 1);
        //                        ((TextBox)sender).SelectionStart = 1 + i;
        //                    }
        //                }
        //            }
        //        }
        //    }
        }
    }
}

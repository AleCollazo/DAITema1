#define teclaChar

namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIzquierdo = new System.Windows.Forms.Button();
            this.btnDerecho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzquierdo
            // 
            this.btnIzquierdo.Location = new System.Drawing.Point(77, 113);
            this.btnIzquierdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzquierdo.Name = "btnIzquierdo";
            this.btnIzquierdo.Size = new System.Drawing.Size(160, 106);
            this.btnIzquierdo.TabIndex = 0;
            this.btnIzquierdo.Text = "Izquierdo";
            this.btnIzquierdo.UseVisualStyleBackColor = true;
            this.btnIzquierdo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // btnDerecho
            // 
            this.btnDerecho.Location = new System.Drawing.Point(362, 113);
            this.btnDerecho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDerecho.Name = "btnDerecho";
            this.btnDerecho.Size = new System.Drawing.Size(160, 106);
            this.btnDerecho.TabIndex = 1;
            this.btnDerecho.Text = "Derecho";
            this.btnDerecho.UseVisualStyleBackColor = true;
            this.btnDerecho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDerecho);
            this.Controls.Add(this.btnIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Mouse Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Button btnIzquierdo;
        private System.Windows.Forms.Button btnDerecho;
    }
}


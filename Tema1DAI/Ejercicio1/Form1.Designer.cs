namespace Ejercicio1
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
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtAmarillo = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(107, 93);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(40, 20);
            this.txtRojo.TabIndex = 1;
            // 
            // txtAmarillo
            // 
            this.txtAmarillo.Location = new System.Drawing.Point(107, 120);
            this.txtAmarillo.Name = "txtAmarillo";
            this.txtAmarillo.Size = new System.Drawing.Size(40, 20);
            this.txtAmarillo.TabIndex = 2;
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(107, 147);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(40, 20);
            this.txtAzul.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(27, 45);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(227, 20);
            this.txtPath.TabIndex = 4;
            this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtAmarillo);
            this.Controls.Add(this.txtRojo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.TextBox txtAmarillo;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.TextBox txtPath;
    }
}


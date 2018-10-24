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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtAmarillo = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(87, 89);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(40, 20);
            this.txtRojo.TabIndex = 1;
            this.txtRojo.Tag = 0;
            // 
            // txtAmarillo
            // 
            this.txtAmarillo.Location = new System.Drawing.Point(87, 116);
            this.txtAmarillo.Name = "txtAmarillo";
            this.txtAmarillo.Size = new System.Drawing.Size(40, 20);
            this.txtAmarillo.TabIndex = 2;
            this.txtAmarillo.Tag = 1;
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(87, 143);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(40, 20);
            this.txtAzul.TabIndex = 3;
            this.txtAzul.Tag = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(23, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(227, 20);
            this.txtPath.TabIndex = 4;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(325, 113);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Fondo Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(325, 24);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(91, 23);
            this.btnImg.TabIndex = 6;
            this.btnImg.Text = "Fondo Imagen";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 232);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtAmarillo);
            this.Controls.Add(this.txtRojo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.TextBox txtAmarillo;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnImg;
    }
}


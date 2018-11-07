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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(26, 106);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(40, 20);
            this.txtRojo.TabIndex = 1;
            this.txtRojo.Tag = 0;
            // 
            // txtAmarillo
            // 
            this.txtAmarillo.Location = new System.Drawing.Point(26, 133);
            this.txtAmarillo.Name = "txtAmarillo";
            this.txtAmarillo.Size = new System.Drawing.Size(40, 20);
            this.txtAmarillo.TabIndex = 2;
            this.txtAmarillo.Tag = 1;
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(26, 160);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(40, 20);
            this.txtAzul.TabIndex = 3;
            this.txtAzul.Tag = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(26, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(227, 20);
            this.txtPath.TabIndex = 4;
            this.txtPath.Text = "C:\\Users\\alex-\\Downloads\\fondo.jpg";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(325, 131);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Fondo Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(325, 40);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(91, 23);
            this.btnImg.TabIndex = 6;
            this.btnImg.Text = "Fondo Imagen";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Introduce la ruta de la imagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Introduce Color RGB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtAmarillo);
            this.Controls.Add(this.txtRojo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


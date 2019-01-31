namespace Ejercicio5
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
            this.tbxDirectory = new System.Windows.Forms.TextBox();
            this.txbWord = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbxCapital = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxDirectory
            // 
            this.tbxDirectory.Location = new System.Drawing.Point(12, 13);
            this.tbxDirectory.Name = "tbxDirectory";
            this.tbxDirectory.Size = new System.Drawing.Size(100, 20);
            this.tbxDirectory.TabIndex = 0;
            // 
            // txbWord
            // 
            this.txbWord.Location = new System.Drawing.Point(155, 13);
            this.txbWord.Name = "txbWord";
            this.txbWord.Size = new System.Drawing.Size(100, 20);
            this.txbWord.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(160, 63);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 63);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 112);
            this.textBox3.TabIndex = 3;
            // 
            // cbxCapital
            // 
            this.cbxCapital.AutoSize = true;
            this.cbxCapital.Location = new System.Drawing.Point(160, 158);
            this.cbxCapital.Name = "cbxCapital";
            this.cbxCapital.Size = new System.Drawing.Size(80, 17);
            this.cbxCapital.TabIndex = 4;
            this.cbxCapital.Text = "checkBox1";
            this.cbxCapital.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cbxCapital);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txbWord);
            this.Controls.Add(this.tbxDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDirectory;
        private System.Windows.Forms.TextBox txbWord;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox cbxCapital;
        private System.Windows.Forms.TextBox textBox4;
    }
}


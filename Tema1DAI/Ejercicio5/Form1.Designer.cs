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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonTimes = new System.Windows.Forms.RadioButton();
            this.radioButtonArial = new System.Windows.Forms.RadioButton();
            this.radioButtonComic = new System.Windows.Forms.RadioButton();
            this.radioButtonRojo = new System.Windows.Forms.RadioButton();
            this.radioButtonAzul = new System.Windows.Forms.RadioButton();
            this.radioButtonVerde = new System.Windows.Forms.RadioButton();
            this.groupBoxFamily = new System.Windows.Forms.GroupBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.tbx = new System.Windows.Forms.TextBox();
            this.groupBoxFamily.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonTimes
            // 
            this.radioButtonTimes.AutoSize = true;
            this.radioButtonTimes.Location = new System.Drawing.Point(20, 19);
            this.radioButtonTimes.Name = "radioButtonTimes";
            this.radioButtonTimes.Size = new System.Drawing.Size(115, 17);
            this.radioButtonTimes.TabIndex = 0;
            this.radioButtonTimes.TabStop = true;
            this.radioButtonTimes.Text = "Times New Roman";
            this.radioButtonTimes.UseVisualStyleBackColor = true;
            this.radioButtonTimes.CheckedChanged += new System.EventHandler(this.CambioFamiliaFuente);
            this.radioButtonTimes.Tag = 16;
            // 
            // radioButtonArial
            // 
            this.radioButtonArial.AutoSize = true;
            this.radioButtonArial.Location = new System.Drawing.Point(20, 58);
            this.radioButtonArial.Name = "radioButtonArial";
            this.radioButtonArial.Size = new System.Drawing.Size(45, 17);
            this.radioButtonArial.TabIndex = 1;
            this.radioButtonArial.TabStop = true;
            this.radioButtonArial.Text = "Arial";
            this.radioButtonArial.UseVisualStyleBackColor = true;
            this.radioButtonArial.CheckedChanged += new System.EventHandler(this.CambioFamiliaFuente);
            this.radioButtonArial.Tag = 12;
            // 
            // radioButtonComic
            // 
            this.radioButtonComic.AutoSize = true;
            this.radioButtonComic.Location = new System.Drawing.Point(20, 97);
            this.radioButtonComic.Name = "radioButtonComic";
            this.radioButtonComic.Size = new System.Drawing.Size(100, 17);
            this.radioButtonComic.TabIndex = 2;
            this.radioButtonComic.TabStop = true;
            this.radioButtonComic.Text = "Comic Sans MS";
            this.radioButtonComic.UseVisualStyleBackColor = true;
            this.radioButtonComic.CheckedChanged += new System.EventHandler(CambioFamiliaFuente);
            this.radioButtonComic.Tag = 10;
            // 
            // radioButtonRojo
            // 
            this.radioButtonRojo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRojo.AutoSize = true;
            this.radioButtonRojo.BackColor = System.Drawing.SystemColors.Desktop;
            this.radioButtonRojo.Location = new System.Drawing.Point(18, 19);
            this.radioButtonRojo.Name = "radioButtonRojo";
            this.radioButtonRojo.Size = new System.Drawing.Size(56, 23);
            this.radioButtonRojo.TabIndex = 4;
            this.radioButtonRojo.Text = "             ";
            this.radioButtonRojo.UseVisualStyleBackColor = false;
            this.radioButtonRojo.CheckedChanged += new System.EventHandler(CambioColor);
            // 
            // radioButtonAzul
            // 
            this.radioButtonAzul.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAzul.AutoSize = true;
            this.radioButtonAzul.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonAzul.Location = new System.Drawing.Point(18, 58);
            this.radioButtonAzul.Name = "radioButtonAzul";
            this.radioButtonAzul.Size = new System.Drawing.Size(56, 23);
            this.radioButtonAzul.TabIndex = 5;
            this.radioButtonAzul.Text = "             ";
            this.radioButtonAzul.UseVisualStyleBackColor = false;
            this.radioButtonAzul.CheckedChanged += new System.EventHandler(CambioColor);
            // 
            // radioButtonVerde
            // 
            this.radioButtonVerde.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonVerde.AutoSize = true;
            this.radioButtonVerde.BackColor = System.Drawing.Color.Green;
            this.radioButtonVerde.Location = new System.Drawing.Point(18, 97);
            this.radioButtonVerde.Name = "radioButtonVerde";
            this.radioButtonVerde.Size = new System.Drawing.Size(56, 23);
            this.radioButtonVerde.TabIndex = 6;
            this.radioButtonVerde.Text = "             ";
            this.radioButtonVerde.UseVisualStyleBackColor = false;
            this.radioButtonVerde.CheckedChanged += new System.EventHandler(CambioColor);
            // 
            // groupBoxFamily
            // 
            this.groupBoxFamily.Controls.Add(this.radioButtonTimes);
            this.groupBoxFamily.Controls.Add(this.radioButtonArial);
            this.groupBoxFamily.Controls.Add(this.radioButtonComic);
            this.groupBoxFamily.Location = new System.Drawing.Point(42, 28);
            this.groupBoxFamily.Name = "groupBoxFamily";
            this.groupBoxFamily.Size = new System.Drawing.Size(153, 129);
            this.groupBoxFamily.TabIndex = 7;
            this.groupBoxFamily.TabStop = false;
            this.groupBoxFamily.Text = "Tipo de Fuente";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonVerde);
            this.groupBoxColor.Controls.Add(this.radioButtonRojo);
            this.groupBoxColor.Controls.Add(this.radioButtonAzul);
            this.groupBoxColor.Location = new System.Drawing.Point(233, 28);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(101, 129);
            this.groupBoxColor.TabIndex = 8;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color de fuente";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(42, 188);
            this.tbx.Multiline = true;
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(292, 134);
            this.tbx.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 359);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxFamily);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Selección tipo de letra";
            this.groupBoxFamily.ResumeLayout(false);
            this.groupBoxFamily.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonTimes;
        private System.Windows.Forms.RadioButton radioButtonArial;
        private System.Windows.Forms.RadioButton radioButtonComic;
        private System.Windows.Forms.RadioButton radioButtonRojo;
        private System.Windows.Forms.RadioButton radioButtonAzul;
        private System.Windows.Forms.RadioButton radioButtonVerde;
        private System.Windows.Forms.GroupBox groupBoxFamily;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.TextBox tbx;
    }
}


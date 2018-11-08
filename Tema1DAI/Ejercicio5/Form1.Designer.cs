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
            this.gbxColorFuente = new System.Windows.Forms.GroupBox();
            this.tbx = new System.Windows.Forms.TextBox();
            this.cbxColor = new System.Windows.Forms.CheckBox();
            this.cbxInvertirColor = new System.Windows.Forms.CheckBox();
            this.gbxColorFondo = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.groupBoxFamily.SuspendLayout();
            this.gbxColorFuente.SuspendLayout();
            this.gbxColorFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonTimes
            // 
            this.radioButtonTimes.AutoSize = true;
            this.radioButtonTimes.Location = new System.Drawing.Point(27, 23);
            this.radioButtonTimes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTimes.Name = "radioButtonTimes";
            this.radioButtonTimes.Size = new System.Drawing.Size(147, 21);
            this.radioButtonTimes.TabIndex = 0;
            this.radioButtonTimes.TabStop = true;
            this.radioButtonTimes.Tag = 16;
            this.radioButtonTimes.Text = "&Times New Roman";
            this.radioButtonTimes.UseVisualStyleBackColor = true;
            this.radioButtonTimes.CheckedChanged += new System.EventHandler(this.cambioFamiliaFuente);
            // 
            // radioButtonArial
            // 
            this.radioButtonArial.AutoSize = true;
            this.radioButtonArial.Location = new System.Drawing.Point(27, 71);
            this.radioButtonArial.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonArial.Name = "radioButtonArial";
            this.radioButtonArial.Size = new System.Drawing.Size(57, 21);
            this.radioButtonArial.TabIndex = 1;
            this.radioButtonArial.TabStop = true;
            this.radioButtonArial.Tag = 12;
            this.radioButtonArial.Text = "&Arial";
            this.radioButtonArial.UseVisualStyleBackColor = true;
            this.radioButtonArial.CheckedChanged += new System.EventHandler(this.cambioFamiliaFuente);
            // 
            // radioButtonComic
            // 
            this.radioButtonComic.AutoSize = true;
            this.radioButtonComic.Location = new System.Drawing.Point(27, 119);
            this.radioButtonComic.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonComic.Name = "radioButtonComic";
            this.radioButtonComic.Size = new System.Drawing.Size(127, 21);
            this.radioButtonComic.TabIndex = 2;
            this.radioButtonComic.TabStop = true;
            this.radioButtonComic.Tag = 10;
            this.radioButtonComic.Text = "Comic &Sans MS";
            this.radioButtonComic.UseVisualStyleBackColor = true;
            this.radioButtonComic.CheckedChanged += new System.EventHandler(this.cambioFamiliaFuente);
            // 
            // radioButtonRojo
            // 
            this.radioButtonRojo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRojo.AutoSize = true;
            this.radioButtonRojo.BackColor = System.Drawing.SystemColors.InfoText;
            this.radioButtonRojo.Location = new System.Drawing.Point(24, 25);
            this.radioButtonRojo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRojo.Name = "radioButtonRojo";
            this.radioButtonRojo.Size = new System.Drawing.Size(70, 27);
            this.radioButtonRojo.TabIndex = 4;
            this.radioButtonRojo.TabStop = true;
            this.radioButtonRojo.Text = "             ";
            this.radioButtonRojo.UseVisualStyleBackColor = false;
            this.radioButtonRojo.CheckedChanged += new System.EventHandler(this.cambioColorFuente);
            // 
            // radioButtonAzul
            // 
            this.radioButtonAzul.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAzul.AutoSize = true;
            this.radioButtonAzul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonAzul.Location = new System.Drawing.Point(24, 73);
            this.radioButtonAzul.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAzul.Name = "radioButtonAzul";
            this.radioButtonAzul.Size = new System.Drawing.Size(70, 27);
            this.radioButtonAzul.TabIndex = 5;
            this.radioButtonAzul.TabStop = true;
            this.radioButtonAzul.Text = "             ";
            this.radioButtonAzul.UseVisualStyleBackColor = false;
            this.radioButtonAzul.CheckedChanged += new System.EventHandler(this.cambioColorFuente);
            // 
            // radioButtonVerde
            // 
            this.radioButtonVerde.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonVerde.AutoSize = true;
            this.radioButtonVerde.BackColor = System.Drawing.Color.Green;
            this.radioButtonVerde.Location = new System.Drawing.Point(24, 121);
            this.radioButtonVerde.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonVerde.Name = "radioButtonVerde";
            this.radioButtonVerde.Size = new System.Drawing.Size(70, 27);
            this.radioButtonVerde.TabIndex = 6;
            this.radioButtonVerde.TabStop = true;
            this.radioButtonVerde.Text = "             ";
            this.radioButtonVerde.UseVisualStyleBackColor = false;
            this.radioButtonVerde.CheckedChanged += new System.EventHandler(this.cambioColorFuente);
            // 
            // groupBoxFamily
            // 
            this.groupBoxFamily.Controls.Add(this.radioButtonTimes);
            this.groupBoxFamily.Controls.Add(this.radioButtonArial);
            this.groupBoxFamily.Controls.Add(this.radioButtonComic);
            this.groupBoxFamily.Location = new System.Drawing.Point(56, 34);
            this.groupBoxFamily.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFamily.Name = "groupBoxFamily";
            this.groupBoxFamily.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFamily.Size = new System.Drawing.Size(204, 159);
            this.groupBoxFamily.TabIndex = 0;
            this.groupBoxFamily.TabStop = false;
            this.groupBoxFamily.Text = "Tipo de Fuente";
            // 
            // gbxColorFuente
            // 
            this.gbxColorFuente.Controls.Add(this.radioButtonVerde);
            this.gbxColorFuente.Controls.Add(this.radioButtonRojo);
            this.gbxColorFuente.Controls.Add(this.radioButtonAzul);
            this.gbxColorFuente.Location = new System.Drawing.Point(311, 34);
            this.gbxColorFuente.Margin = new System.Windows.Forms.Padding(4);
            this.gbxColorFuente.Name = "gbxColorFuente";
            this.gbxColorFuente.Padding = new System.Windows.Forms.Padding(4);
            this.gbxColorFuente.Size = new System.Drawing.Size(135, 159);
            this.gbxColorFuente.TabIndex = 4;
            this.gbxColorFuente.TabStop = false;
            this.gbxColorFuente.Text = "Color de fuente";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(56, 231);
            this.tbx.Margin = new System.Windows.Forms.Padding(4);
            this.tbx.Multiline = true;
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(764, 164);
            this.tbx.TabIndex = 13;
            // 
            // cbxColor
            // 
            this.cbxColor.AutoSize = true;
            this.cbxColor.Checked = true;
            this.cbxColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxColor.Location = new System.Drawing.Point(703, 57);
            this.cbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(117, 21);
            this.cbxColor.TabIndex = 10;
            this.cbxColor.Text = "&Cambiar color";
            this.cbxColor.UseVisualStyleBackColor = true;
            this.cbxColor.CheckedChanged += new System.EventHandler(this.cbxColor_CheckedChanged);
            // 
            // cbxInvertirColor
            // 
            this.cbxInvertirColor.AutoSize = true;
            this.cbxInvertirColor.Location = new System.Drawing.Point(703, 86);
            this.cbxInvertirColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxInvertirColor.Name = "cbxInvertirColor";
            this.cbxInvertirColor.Size = new System.Drawing.Size(123, 21);
            this.cbxInvertirColor.TabIndex = 11;
            this.cbxInvertirColor.Text = "&Invertir colores";
            this.cbxInvertirColor.UseVisualStyleBackColor = true;
            this.cbxInvertirColor.CheckedChanged += new System.EventHandler(this.cbxInvertirColor_CheckedChanged);
            // 
            // gbxColorFondo
            // 
            this.gbxColorFondo.Controls.Add(this.radioButton3);
            this.gbxColorFondo.Controls.Add(this.radioButton2);
            this.gbxColorFondo.Controls.Add(this.radioButton1);
            this.gbxColorFondo.Location = new System.Drawing.Point(499, 34);
            this.gbxColorFondo.Name = "gbxColorFondo";
            this.gbxColorFondo.Size = new System.Drawing.Size(133, 159);
            this.gbxColorFondo.TabIndex = 7;
            this.gbxColorFondo.TabStop = false;
            this.gbxColorFondo.Text = "Color de fondo";
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton3.Location = new System.Drawing.Point(20, 25);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 27);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "             ";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.cambioColorFondo);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(20, 70);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 27);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "             ";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.cambioColorFondo);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton1.Location = new System.Drawing.Point(20, 118);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 27);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "             ";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.cambioColorFondo);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(703, 150);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(117, 30);
            this.btnSeleccion.TabIndex = 12;
            this.btnSeleccion.Text = "S&elección";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 443);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.gbxColorFondo);
            this.Controls.Add(this.cbxInvertirColor);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.gbxColorFuente);
            this.Controls.Add(this.groupBoxFamily);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 490);
            this.Name = "Form1";
            this.Text = "Selección tipo de letra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBoxFamily.ResumeLayout(false);
            this.groupBoxFamily.PerformLayout();
            this.gbxColorFuente.ResumeLayout(false);
            this.gbxColorFuente.PerformLayout();
            this.gbxColorFondo.ResumeLayout(false);
            this.gbxColorFondo.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxColorFuente;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.CheckBox cbxColor;
        private System.Windows.Forms.CheckBox cbxInvertirColor;
        private System.Windows.Forms.GroupBox gbxColorFondo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSeleccion;
    }
}


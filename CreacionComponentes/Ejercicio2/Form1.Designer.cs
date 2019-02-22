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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblDir = new System.Windows.Forms.Label();
            this.tbxDir = new System.Windows.Forms.TextBox();
            this.pbx = new System.Windows.Forms.PictureBox();
            this.controlMultimedia = new Ejercicio2.ControlMultimedia();
            this.controlMultimedia3 = new Ejercicio2.ControlMultimedia();
            this.controlMultimedia2 = new Ejercicio2.ControlMultimedia();
            this.labelTextBox2 = new Ejercicio2.LabelTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(9, 33);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 14;
            this.lblDir.Text = "Directorio";
            // 
            // tbxDir
            // 
            this.tbxDir.Location = new System.Drawing.Point(12, 58);
            this.tbxDir.Name = "tbxDir";
            this.tbxDir.Size = new System.Drawing.Size(100, 20);
            this.tbxDir.TabIndex = 15;
            this.tbxDir.Text = "C:\\Users\\alex-\\Downloads";
            // 
            // pbx
            // 
            this.pbx.Location = new System.Drawing.Point(122, 12);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(424, 363);
            this.pbx.TabIndex = 17;
            this.pbx.TabStop = false;
            // 
            // controlMultimedia
            // 
            this.controlMultimedia.AutoSize = true;
            this.controlMultimedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlMultimedia.Location = new System.Drawing.Point(12, 138);
            this.controlMultimedia.Name = "controlMultimedia";
            this.controlMultimedia.Size = new System.Drawing.Size(90, 113);
            this.controlMultimedia.TabIndex = 18;
            this.controlMultimedia.TextLblTiempoXX = 0;
            this.controlMultimedia.TextLblTiempoYY = 0;
            this.controlMultimedia.DesbordaTiempo += new System.EventHandler(this.controlMultimedia_DesbordaTiempo);
            this.controlMultimedia.Pulsacion += new System.EventHandler<Ejercicio2.PulsacionEventArgs>(this.controlMultimedia_Pulsacion);
            // 
            // controlMultimedia3
            // 
            this.controlMultimedia3.AutoSize = true;
            this.controlMultimedia3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlMultimedia3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlMultimedia3.Location = new System.Drawing.Point(2977, 2759);
            this.controlMultimedia3.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.controlMultimedia3.Name = "controlMultimedia3";
            this.controlMultimedia3.Size = new System.Drawing.Size(574, 651);
            this.controlMultimedia3.TabIndex = 13;
            this.controlMultimedia3.TextLblTiempoXX = 0;
            this.controlMultimedia3.TextLblTiempoYY = 0;
            // 
            // controlMultimedia2
            // 
            this.controlMultimedia2.AutoSize = true;
            this.controlMultimedia2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlMultimedia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlMultimedia2.Location = new System.Drawing.Point(445, 1087);
            this.controlMultimedia2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.controlMultimedia2.Name = "controlMultimedia2";
            this.controlMultimedia2.Size = new System.Drawing.Size(237, 281);
            this.controlMultimedia2.TabIndex = 11;
            this.controlMultimedia2.TextLblTiempoXX = 0;
            this.controlMultimedia2.TextLblTiempoYY = 0;
            // 
            // labelTextBox2
            // 
            this.labelTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBox2.Location = new System.Drawing.Point(472, 1078);
            this.labelTextBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.labelTextBox2.Name = "labelTextBox2";
            this.labelTextBox2.Posicion = Ejercicio2.LabelTextBox.ePosicion.IZQUIERDA;
            this.labelTextBox2.Separacion = 0;
            this.labelTextBox2.Size = new System.Drawing.Size(707, 48);
            this.labelTextBox2.TabIndex = 9;
            this.labelTextBox2.TextLbl = "LabelTextBox";
            this.labelTextBox2.TextTxt = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 782);
            this.Controls.Add(this.controlMultimedia);
            this.Controls.Add(this.pbx);
            this.Controls.Add(this.tbxDir);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.controlMultimedia3);
            this.Controls.Add(this.controlMultimedia2);
            this.Controls.Add(this.labelTextBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Visor de imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelTextBox labelTextBox2;
        private ControlMultimedia controlMultimedia2;
        private ControlMultimedia controlMultimedia3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox tbxDir;
        private System.Windows.Forms.PictureBox pbx;
        private ControlMultimedia controlMultimedia;
    }
}


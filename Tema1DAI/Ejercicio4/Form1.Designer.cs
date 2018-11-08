namespace Ejercicio4
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
            this.tbxNum1 = new System.Windows.Forms.TextBox();
            this.tbxNum2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtSuma = new System.Windows.Forms.RadioButton();
            this.rbtResta = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicación = new System.Windows.Forms.RadioButton();
            this.rbtDivision = new System.Windows.Forms.RadioButton();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbxOperadores = new System.Windows.Forms.GroupBox();
            this.gbxOperadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNum1
            // 
            this.tbxNum1.Location = new System.Drawing.Point(56, 43);
            this.tbxNum1.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(76, 20);
            this.tbxNum1.TabIndex = 0;
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(56, 130);
            this.tbxNum2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(76, 20);
            this.tbxNum2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(143, 221);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 25);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtSuma
            // 
            this.rbtSuma.AutoSize = true;
            this.rbtSuma.Checked = true;
            this.rbtSuma.Location = new System.Drawing.Point(22, 27);
            this.rbtSuma.Margin = new System.Windows.Forms.Padding(2);
            this.rbtSuma.Name = "rbtSuma";
            this.rbtSuma.Size = new System.Drawing.Size(52, 17);
            this.rbtSuma.TabIndex = 3;
            this.rbtSuma.TabStop = true;
            this.rbtSuma.Text = "Suma";
            this.rbtSuma.UseVisualStyleBackColor = true;
            this.rbtSuma.Tag = "+";
            // 
            // rbtResta
            // 
            this.rbtResta.AutoSize = true;
            this.rbtResta.Location = new System.Drawing.Point(22, 62);
            this.rbtResta.Margin = new System.Windows.Forms.Padding(2);
            this.rbtResta.Name = "rbtResta";
            this.rbtResta.Size = new System.Drawing.Size(53, 17);
            this.rbtResta.TabIndex = 4;
            this.rbtResta.Text = "Resta";
            this.rbtResta.UseVisualStyleBackColor = true;
            this.rbtResta.Tag = "-";
            // 
            // rbtMultiplicación
            // 
            this.rbtMultiplicación.AutoSize = true;
            this.rbtMultiplicación.Location = new System.Drawing.Point(22, 100);
            this.rbtMultiplicación.Margin = new System.Windows.Forms.Padding(2);
            this.rbtMultiplicación.Name = "rbtMultiplicación";
            this.rbtMultiplicación.Size = new System.Drawing.Size(89, 17);
            this.rbtMultiplicación.TabIndex = 5;
            this.rbtMultiplicación.Text = "Multiplicación";
            this.rbtMultiplicación.UseVisualStyleBackColor = true;
            this.rbtMultiplicación.Tag = "*";
            // 
            // rbtDivision
            // 
            this.rbtDivision.AutoSize = true;
            this.rbtDivision.Location = new System.Drawing.Point(22, 137);
            this.rbtDivision.Margin = new System.Windows.Forms.Padding(2);
            this.rbtDivision.Name = "rbtDivision";
            this.rbtDivision.Size = new System.Drawing.Size(62, 17);
            this.rbtDivision.TabIndex = 6;
            this.rbtDivision.Text = "División";
            this.rbtDivision.UseVisualStyleBackColor = true;
            this.rbtDivision.Tag = "/";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(85, 87);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(13, 13);
            this.lblOperador.TabIndex = 7;
            this.lblOperador.Text = "+";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(88, 177);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "=";
            // 
            // gbxOperadores
            // 
            this.gbxOperadores.Controls.Add(this.rbtMultiplicación);
            this.gbxOperadores.Controls.Add(this.rbtSuma);
            this.gbxOperadores.Controls.Add(this.rbtResta);
            this.gbxOperadores.Controls.Add(this.rbtDivision);
            this.gbxOperadores.Location = new System.Drawing.Point(200, 25);
            this.gbxOperadores.Name = "gbxOperadores";
            this.gbxOperadores.Size = new System.Drawing.Size(135, 165);
            this.gbxOperadores.TabIndex = 9;
            this.gbxOperadores.TabStop = false;
            this.gbxOperadores.Text = "Operadores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 268);
            this.Controls.Add(this.gbxOperadores);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.tbxNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.gbxOperadores.ResumeLayout(false);
            this.gbxOperadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbtSuma;
        private System.Windows.Forms.RadioButton rbtResta;
        private System.Windows.Forms.RadioButton rbtMultiplicación;
        private System.Windows.Forms.RadioButton rbtDivision;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gbxOperadores;
    }
}


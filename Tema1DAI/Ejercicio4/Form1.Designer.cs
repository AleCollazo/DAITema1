﻿namespace Ejercicio4
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
            this.tbxNum1.Location = new System.Drawing.Point(75, 53);
            this.tbxNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(100, 22);
            this.tbxNum1.TabIndex = 0;
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(75, 160);
            this.tbxNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(100, 22);
            this.tbxNum2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(191, 272);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 31);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtSuma
            // 
            this.rbtSuma.AutoSize = true;
            this.rbtSuma.Checked = true;
            this.rbtSuma.Location = new System.Drawing.Point(29, 33);
            this.rbtSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtSuma.Name = "rbtSuma";
            this.rbtSuma.Size = new System.Drawing.Size(65, 21);
            this.rbtSuma.TabIndex = 3;
            this.rbtSuma.TabStop = true;
            this.rbtSuma.Tag = "+";
            this.rbtSuma.Text = "Suma";
            this.rbtSuma.UseVisualStyleBackColor = true;
            this.rbtSuma.CheckedChanged += new System.EventHandler(this.cambiarOperacion);
            // 
            // rbtResta
            // 
            this.rbtResta.AutoSize = true;
            this.rbtResta.Location = new System.Drawing.Point(29, 76);
            this.rbtResta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtResta.Name = "rbtResta";
            this.rbtResta.Size = new System.Drawing.Size(66, 21);
            this.rbtResta.TabIndex = 4;
            this.rbtResta.Tag = "-";
            this.rbtResta.Text = "Resta";
            this.rbtResta.UseVisualStyleBackColor = true;
            this.rbtResta.CheckedChanged += new System.EventHandler(this.cambiarOperacion);
            // 
            // rbtMultiplicación
            // 
            this.rbtMultiplicación.AutoSize = true;
            this.rbtMultiplicación.Location = new System.Drawing.Point(29, 123);
            this.rbtMultiplicación.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMultiplicación.Name = "rbtMultiplicación";
            this.rbtMultiplicación.Size = new System.Drawing.Size(113, 21);
            this.rbtMultiplicación.TabIndex = 5;
            this.rbtMultiplicación.Tag = "*";
            this.rbtMultiplicación.Text = "Multiplicación";
            this.rbtMultiplicación.UseVisualStyleBackColor = true;
            this.rbtMultiplicación.CheckedChanged += new System.EventHandler(this.cambiarOperacion);
            // 
            // rbtDivision
            // 
            this.rbtDivision.AutoSize = true;
            this.rbtDivision.Location = new System.Drawing.Point(29, 169);
            this.rbtDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtDivision.Name = "rbtDivision";
            this.rbtDivision.Size = new System.Drawing.Size(78, 21);
            this.rbtDivision.TabIndex = 6;
            this.rbtDivision.Tag = "/";
            this.rbtDivision.Text = "División";
            this.rbtDivision.UseVisualStyleBackColor = true;
            this.rbtDivision.CheckedChanged += new System.EventHandler(this.cambiarOperacion);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(113, 107);
            this.lblOperador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(16, 17);
            this.lblOperador.TabIndex = 7;
            this.lblOperador.Text = "+";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(117, 218);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 17);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "=";
            // 
            // gbxOperadores
            // 
            this.gbxOperadores.Controls.Add(this.rbtMultiplicación);
            this.gbxOperadores.Controls.Add(this.rbtSuma);
            this.gbxOperadores.Controls.Add(this.rbtResta);
            this.gbxOperadores.Controls.Add(this.rbtDivision);
            this.gbxOperadores.Location = new System.Drawing.Point(267, 31);
            this.gbxOperadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxOperadores.Name = "gbxOperadores";
            this.gbxOperadores.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxOperadores.Size = new System.Drawing.Size(180, 203);
            this.gbxOperadores.TabIndex = 9;
            this.gbxOperadores.TabStop = false;
            this.gbxOperadores.Text = "Operadores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 330);
            this.Controls.Add(this.gbxOperadores);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.tbxNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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


﻿namespace Ejercicio3
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
            this.cbxModal = new System.Windows.Forms.CheckBox();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxModal
            // 
            this.cbxModal.AutoSize = true;
            this.cbxModal.Location = new System.Drawing.Point(214, 159);
            this.cbxModal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxModal.Name = "cbxModal";
            this.cbxModal.Size = new System.Drawing.Size(55, 17);
            this.cbxModal.TabIndex = 0;
            this.cbxModal.Text = "Modal";
            this.cbxModal.UseVisualStyleBackColor = true;
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(61, 152);
            this.btnOpenForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(94, 29);
            this.btnOpenForm.TabIndex = 1;
            this.btnOpenForm.Text = "Abrir Imagen";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(61, 70);
            this.tbxPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(225, 20);
            this.tbxPath.TabIndex = 2;
            this.tbxPath.Text = "C:\\Users\\alex-\\Downloads\\fondo.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 253);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.cbxModal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Visor de imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxModal;
        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.TextBox tbxPath;
    }
}


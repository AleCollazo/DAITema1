namespace Ejercicio3
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
            this.cbxModal = new System.Windows.Forms.CheckBox();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxModal
            // 
            this.cbxModal.AutoSize = true;
            this.cbxModal.Location = new System.Drawing.Point(286, 196);
            this.cbxModal.Name = "cbxModal";
            this.cbxModal.Size = new System.Drawing.Size(68, 21);
            this.cbxModal.TabIndex = 0;
            this.cbxModal.Text = "Modal";
            this.cbxModal.UseVisualStyleBackColor = true;
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(81, 194);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(125, 23);
            this.btnOpenForm.TabIndex = 1;
            this.btnOpenForm.Text = "Open new Form";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(81, 86);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(299, 22);
            this.tbxPath.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 311);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.cbxModal);
            this.Name = "Form1";
            this.Text = "Form1";
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


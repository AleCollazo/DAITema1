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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiquetaAviso5 = new Ejercicio2.EtiquetaAviso();
            this.etiquetaAviso4 = new Ejercicio2.EtiquetaAviso();
            this.etiquetaAviso3 = new Ejercicio2.EtiquetaAviso();
            this.etiquetaAviso2 = new Ejercicio2.EtiquetaAviso();
            this.etiquetaAviso1 = new Ejercicio2.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso5
            // 
            this.etiquetaAviso5.Color1 = System.Drawing.Color.LightBlue;
            this.etiquetaAviso5.Color2 = System.Drawing.Color.LemonChiffon;
            this.etiquetaAviso5.ImagenMarca = ((System.Drawing.Image)(resources.GetObject("etiquetaAviso5.ImagenMarca")));
            this.etiquetaAviso5.IsGradiente = true;
            this.etiquetaAviso5.Location = new System.Drawing.Point(144, 206);
            this.etiquetaAviso5.Marca = Ejercicio2.EtiquetaAviso.eMarca.ImagenMarca;
            this.etiquetaAviso5.Name = "etiquetaAviso5";
            this.etiquetaAviso5.Size = new System.Drawing.Size(111, 23);
            this.etiquetaAviso5.TabIndex = 4;
            this.etiquetaAviso5.Text = "etiquetaAviso5";
            this.etiquetaAviso5.ClickMarca += new System.EventHandler(this.etiquetaAviso1_ClickMarca);
            // 
            // etiquetaAviso4
            // 
            this.etiquetaAviso4.Color1 = System.Drawing.Color.LightBlue;
            this.etiquetaAviso4.Color2 = System.Drawing.Color.LemonChiffon;
            this.etiquetaAviso4.ImagenMarca = null;
            this.etiquetaAviso4.IsGradiente = true;
            this.etiquetaAviso4.Location = new System.Drawing.Point(26, 216);
            this.etiquetaAviso4.Marca = Ejercicio2.EtiquetaAviso.eMarca.Nada;
            this.etiquetaAviso4.Name = "etiquetaAviso4";
            this.etiquetaAviso4.Size = new System.Drawing.Size(78, 13);
            this.etiquetaAviso4.TabIndex = 3;
            this.etiquetaAviso4.Text = "etiquetaAviso4";
            this.etiquetaAviso4.ClickMarca += new System.EventHandler(this.etiquetaAviso1_ClickMarca);
            // 
            // etiquetaAviso3
            // 
            this.etiquetaAviso3.Color1 = System.Drawing.Color.LightBlue;
            this.etiquetaAviso3.Color2 = System.Drawing.Color.LemonChiffon;
            this.etiquetaAviso3.ImagenMarca = null;
            this.etiquetaAviso3.IsGradiente = true;
            this.etiquetaAviso3.Location = new System.Drawing.Point(80, 117);
            this.etiquetaAviso3.Marca = Ejercicio2.EtiquetaAviso.eMarca.Circulo;
            this.etiquetaAviso3.Name = "etiquetaAviso3";
            this.etiquetaAviso3.Size = new System.Drawing.Size(131, 53);
            this.etiquetaAviso3.TabIndex = 2;
            this.etiquetaAviso3.Text = "etiquetaAviso3";
            this.etiquetaAviso3.ClickMarca += new System.EventHandler(this.etiquetaAviso1_ClickMarca);
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.Color1 = System.Drawing.Color.LightBlue;
            this.etiquetaAviso2.Color2 = System.Drawing.Color.LemonChiffon;
            this.etiquetaAviso2.ImagenMarca = null;
            this.etiquetaAviso2.IsGradiente = true;
            this.etiquetaAviso2.Location = new System.Drawing.Point(121, 67);
            this.etiquetaAviso2.Marca = Ejercicio2.EtiquetaAviso.eMarca.Cruz;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(101, 17);
            this.etiquetaAviso2.TabIndex = 1;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            this.etiquetaAviso2.ClickMarca += new System.EventHandler(this.etiquetaAviso1_ClickMarca);
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Color1 = System.Drawing.Color.LightBlue;
            this.etiquetaAviso1.Color2 = System.Drawing.Color.LemonChiffon;
            this.etiquetaAviso1.ImagenMarca = null;
            this.etiquetaAviso1.IsGradiente = true;
            this.etiquetaAviso1.Location = new System.Drawing.Point(92, 31);
            this.etiquetaAviso1.Marca = Ejercicio2.EtiquetaAviso.eMarca.ImagenMarca;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(78, 13);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClickMarca += new System.EventHandler(this.etiquetaAviso1_ClickMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.etiquetaAviso5);
            this.Controls.Add(this.etiquetaAviso4);
            this.Controls.Add(this.etiquetaAviso3);
            this.Controls.Add(this.etiquetaAviso2);
            this.Controls.Add(this.etiquetaAviso1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private EtiquetaAviso etiquetaAviso1;
        private EtiquetaAviso etiquetaAviso2;
        private EtiquetaAviso etiquetaAviso3;
        private EtiquetaAviso etiquetaAviso4;
        private EtiquetaAviso etiquetaAviso5;
    }
}


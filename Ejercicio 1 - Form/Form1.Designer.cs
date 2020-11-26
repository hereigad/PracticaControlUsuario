namespace Ejercicio_1___Form
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
            this.botonesNumerados1 = new Prueba.BotonesNumerados();
            this.SuspendLayout();
            // 
            // botonesNumerados1
            // 
            this.botonesNumerados1.AutoSize = true;
            this.botonesNumerados1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonesNumerados1.Location = new System.Drawing.Point(352, 156);
            this.botonesNumerados1.Name = "botonesNumerados1";
            this.botonesNumerados1.Size = new System.Drawing.Size(138, 138);
            this.botonesNumerados1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonesNumerados1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Prueba.BotonesNumerados botonesNumerados1;
    }
}


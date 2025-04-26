namespace FutronicTestApp
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
            this.btnEnrolarHuella = new System.Windows.Forms.Button();
            this.btnVerificarHuella = new System.Windows.Forms.Button();
            this.pbHuella = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnrolarHuella
            // 
            this.btnEnrolarHuella.Location = new System.Drawing.Point(111, 113);
            this.btnEnrolarHuella.Name = "btnEnrolarHuella";
            this.btnEnrolarHuella.Size = new System.Drawing.Size(75, 23);
            this.btnEnrolarHuella.TabIndex = 0;
            this.btnEnrolarHuella.Text = "Enrolar";
            this.btnEnrolarHuella.UseVisualStyleBackColor = true;
            this.btnEnrolarHuella.Click += new System.EventHandler(this.btnEnrolarHuella_Click);
            // 
            // btnVerificarHuella
            // 
            this.btnVerificarHuella.Location = new System.Drawing.Point(111, 255);
            this.btnVerificarHuella.Name = "btnVerificarHuella";
            this.btnVerificarHuella.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarHuella.TabIndex = 1;
            this.btnVerificarHuella.Text = "Verificar";
            this.btnVerificarHuella.UseVisualStyleBackColor = true;
            // 
            // pbHuella
            // 
            this.pbHuella.Location = new System.Drawing.Point(298, 125);
            this.pbHuella.Name = "pbHuella";
            this.pbHuella.Size = new System.Drawing.Size(117, 142);
            this.pbHuella.TabIndex = 2;
            this.pbHuella.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(473, 196);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pbHuella);
            this.Controls.Add(this.btnVerificarHuella);
            this.Controls.Add(this.btnEnrolarHuella);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnrolarHuella;
        private System.Windows.Forms.Button btnVerificarHuella;
        private System.Windows.Forms.PictureBox pbHuella;
        private System.Windows.Forms.Label lblResultado;
    }
}


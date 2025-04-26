namespace FutronicTestApp.Vista
{
    partial class VerificarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificarHuella = new System.Windows.Forms.Button();
            this.pbHuellaVerificada = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuellaVerificada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerificarHuella
            // 
            this.btnVerificarHuella.Location = new System.Drawing.Point(105, 83);
            this.btnVerificarHuella.Name = "btnVerificarHuella";
            this.btnVerificarHuella.Size = new System.Drawing.Size(117, 53);
            this.btnVerificarHuella.TabIndex = 0;
            this.btnVerificarHuella.Text = "Verificar Huella";
            this.btnVerificarHuella.UseVisualStyleBackColor = true;
            this.btnVerificarHuella.Click += new System.EventHandler(this.btnVerificarHuella_Click);
            // 
            // pbHuellaVerificada
            // 
            this.pbHuellaVerificada.Location = new System.Drawing.Point(255, 55);
            this.pbHuellaVerificada.Name = "pbHuellaVerificada";
            this.pbHuellaVerificada.Size = new System.Drawing.Size(94, 122);
            this.pbHuellaVerificada.TabIndex = 1;
            this.pbHuellaVerificada.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(203, 221);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "label1";
            // 
            // VerificarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pbHuellaVerificada);
            this.Controls.Add(this.btnVerificarHuella);
            this.Name = "VerificarForm";
            this.Text = "VerificarHuellaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbHuellaVerificada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificarHuella;
        private System.Windows.Forms.PictureBox pbHuellaVerificada;
        private System.Windows.Forms.Label lblResultado;
    }
}
namespace AskMoose_v1._0
{
    partial class EricFormRegistrarse
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
            this.botonInicioDesdeFormRegistro = new System.Windows.Forms.Button();
            this.botonAtrasFormRegistro = new System.Windows.Forms.Button();
            this.labelRellenaCamposFormRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonInicioDesdeFormRegistro
            // 
            this.botonInicioDesdeFormRegistro.Location = new System.Drawing.Point(197, 227);
            this.botonInicioDesdeFormRegistro.Name = "botonInicioDesdeFormRegistro";
            this.botonInicioDesdeFormRegistro.Size = new System.Drawing.Size(75, 23);
            this.botonInicioDesdeFormRegistro.TabIndex = 0;
            this.botonInicioDesdeFormRegistro.Text = "Inicio";
            this.botonInicioDesdeFormRegistro.UseVisualStyleBackColor = true;
            this.botonInicioDesdeFormRegistro.Click += new System.EventHandler(this.botonInicioDesdeFormRegistro_Click);
            // 
            // botonAtrasFormRegistro
            // 
            this.botonAtrasFormRegistro.Location = new System.Drawing.Point(13, 226);
            this.botonAtrasFormRegistro.Name = "botonAtrasFormRegistro";
            this.botonAtrasFormRegistro.Size = new System.Drawing.Size(75, 23);
            this.botonAtrasFormRegistro.TabIndex = 1;
            this.botonAtrasFormRegistro.Text = "Atrás";
            this.botonAtrasFormRegistro.UseVisualStyleBackColor = true;
            this.botonAtrasFormRegistro.Click += new System.EventHandler(this.botonAtrasFormRegistro_Click);
            // 
            // labelRellenaCamposFormRegistro
            // 
            this.labelRellenaCamposFormRegistro.AutoSize = true;
            this.labelRellenaCamposFormRegistro.Location = new System.Drawing.Point(13, 13);
            this.labelRellenaCamposFormRegistro.Name = "labelRellenaCamposFormRegistro";
            this.labelRellenaCamposFormRegistro.Size = new System.Drawing.Size(187, 13);
            this.labelRellenaCamposFormRegistro.TabIndex = 2;
            this.labelRellenaCamposFormRegistro.Text = "Rellena los campos para crear tu perfil";
            // 
            // EricFormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelRellenaCamposFormRegistro);
            this.Controls.Add(this.botonAtrasFormRegistro);
            this.Controls.Add(this.botonInicioDesdeFormRegistro);
            this.Name = "EricFormRegistrarse";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonInicioDesdeFormRegistro;
        private System.Windows.Forms.Button botonAtrasFormRegistro;
        private System.Windows.Forms.Label labelRellenaCamposFormRegistro;
    }
}
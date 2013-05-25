namespace AskMoose_v1._0
{
    partial class RodrigoFormPerfiles
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
            this.botonInicioDesdeFormPerfiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonInicioDesdeFormPerfiles
            // 
            this.botonInicioDesdeFormPerfiles.Location = new System.Drawing.Point(197, 227);
            this.botonInicioDesdeFormPerfiles.Name = "botonInicioDesdeFormPerfiles";
            this.botonInicioDesdeFormPerfiles.Size = new System.Drawing.Size(75, 23);
            this.botonInicioDesdeFormPerfiles.TabIndex = 0;
            this.botonInicioDesdeFormPerfiles.Text = "Inicio";
            this.botonInicioDesdeFormPerfiles.UseVisualStyleBackColor = true;
            this.botonInicioDesdeFormPerfiles.Click += new System.EventHandler(this.botonInicioDesdeFormPerfiles_Click);
            // 
            // RodrigoFormPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.botonInicioDesdeFormPerfiles);
            this.Name = "RodrigoFormPerfiles";
            this.Text = "Perfiles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonInicioDesdeFormPerfiles;
    }
}
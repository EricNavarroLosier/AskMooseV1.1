namespace AskMoose_v1._0
{
    partial class EricFormLoginRegistro
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
            this.botonInicioFormLoginRegistro = new System.Windows.Forms.Button();
            this.botonEntrarFormLoginRegistro = new System.Windows.Forms.Button();
            this.botonRegistrateFormLoginRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserFormLoginRegistro = new System.Windows.Forms.Label();
            this.textBoxUserFormLoginregistro = new System.Windows.Forms.TextBox();
            this.labelPasswordFormLoginRegistro = new System.Windows.Forms.Label();
            this.textBoxPasswordFormLoginRegistro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonInicioFormLoginRegistro
            // 
            this.botonInicioFormLoginRegistro.Location = new System.Drawing.Point(237, 134);
            this.botonInicioFormLoginRegistro.Name = "botonInicioFormLoginRegistro";
            this.botonInicioFormLoginRegistro.Size = new System.Drawing.Size(75, 23);
            this.botonInicioFormLoginRegistro.TabIndex = 0;
            this.botonInicioFormLoginRegistro.Text = "Inicio";
            this.botonInicioFormLoginRegistro.UseVisualStyleBackColor = true;
            this.botonInicioFormLoginRegistro.Click += new System.EventHandler(this.botonInicioFormLoginRegistro_Click);
            // 
            // botonEntrarFormLoginRegistro
            // 
            this.botonEntrarFormLoginRegistro.Location = new System.Drawing.Point(12, 134);
            this.botonEntrarFormLoginRegistro.Name = "botonEntrarFormLoginRegistro";
            this.botonEntrarFormLoginRegistro.Size = new System.Drawing.Size(75, 23);
            this.botonEntrarFormLoginRegistro.TabIndex = 1;
            this.botonEntrarFormLoginRegistro.Text = "Entrar";
            this.botonEntrarFormLoginRegistro.UseVisualStyleBackColor = true;
            // 
            // botonRegistrateFormLoginRegistro
            // 
            this.botonRegistrateFormLoginRegistro.Location = new System.Drawing.Point(237, 12);
            this.botonRegistrateFormLoginRegistro.Name = "botonRegistrateFormLoginRegistro";
            this.botonRegistrateFormLoginRegistro.Size = new System.Drawing.Size(75, 23);
            this.botonRegistrateFormLoginRegistro.TabIndex = 2;
            this.botonRegistrateFormLoginRegistro.Text = "Regístrate";
            this.botonRegistrateFormLoginRegistro.UseVisualStyleBackColor = true;
            this.botonRegistrateFormLoginRegistro.Click += new System.EventHandler(this.botonRegistrateFormLoginRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A ver cómo validamos el Login (el boton Entrar no funciona aún)";
            // 
            // labelUserFormLoginRegistro
            // 
            this.labelUserFormLoginRegistro.AutoSize = true;
            this.labelUserFormLoginRegistro.Location = new System.Drawing.Point(13, 12);
            this.labelUserFormLoginRegistro.Name = "labelUserFormLoginRegistro";
            this.labelUserFormLoginRegistro.Size = new System.Drawing.Size(29, 13);
            this.labelUserFormLoginRegistro.TabIndex = 4;
            this.labelUserFormLoginRegistro.Text = "User";
            // 
            // textBoxUserFormLoginregistro
            // 
            this.textBoxUserFormLoginregistro.Location = new System.Drawing.Point(13, 29);
            this.textBoxUserFormLoginregistro.Name = "textBoxUserFormLoginregistro";
            this.textBoxUserFormLoginregistro.Size = new System.Drawing.Size(140, 20);
            this.textBoxUserFormLoginregistro.TabIndex = 5;
            // 
            // labelPasswordFormLoginRegistro
            // 
            this.labelPasswordFormLoginRegistro.AutoSize = true;
            this.labelPasswordFormLoginRegistro.Location = new System.Drawing.Point(13, 62);
            this.labelPasswordFormLoginRegistro.Name = "labelPasswordFormLoginRegistro";
            this.labelPasswordFormLoginRegistro.Size = new System.Drawing.Size(53, 13);
            this.labelPasswordFormLoginRegistro.TabIndex = 6;
            this.labelPasswordFormLoginRegistro.Text = "Password";
            // 
            // textBoxPasswordFormLoginRegistro
            // 
            this.textBoxPasswordFormLoginRegistro.Location = new System.Drawing.Point(16, 78);
            this.textBoxPasswordFormLoginRegistro.Name = "textBoxPasswordFormLoginRegistro";
            this.textBoxPasswordFormLoginRegistro.Size = new System.Drawing.Size(137, 20);
            this.textBoxPasswordFormLoginRegistro.TabIndex = 7;
            // 
            // EricFormLoginRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 170);
            this.Controls.Add(this.textBoxPasswordFormLoginRegistro);
            this.Controls.Add(this.labelPasswordFormLoginRegistro);
            this.Controls.Add(this.textBoxUserFormLoginregistro);
            this.Controls.Add(this.labelUserFormLoginRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRegistrateFormLoginRegistro);
            this.Controls.Add(this.botonEntrarFormLoginRegistro);
            this.Controls.Add(this.botonInicioFormLoginRegistro);
            this.Name = "EricFormLoginRegistro";
            this.Text = "EricFormLoginRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonInicioFormLoginRegistro;
        private System.Windows.Forms.Button botonEntrarFormLoginRegistro;
        private System.Windows.Forms.Button botonRegistrateFormLoginRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserFormLoginRegistro;
        private System.Windows.Forms.TextBox textBoxUserFormLoginregistro;
        private System.Windows.Forms.Label labelPasswordFormLoginRegistro;
        private System.Windows.Forms.TextBox textBoxPasswordFormLoginRegistro;
    }
}
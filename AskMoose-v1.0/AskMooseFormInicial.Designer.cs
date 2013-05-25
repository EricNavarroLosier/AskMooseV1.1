namespace AskMoose_v1._0
{
    partial class AskMooseFormInicial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskMooseFormInicial));
            this.botonLoginFormAskMooseInicial = new System.Windows.Forms.Button();
            this.botonPreguntasFormAskMoose = new System.Windows.Forms.Button();
            this.botonPerfilesFormAskMooseInicial = new System.Windows.Forms.Button();
            this.botonSalirFormAskMoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonLoginFormAskMooseInicial
            // 
            this.botonLoginFormAskMooseInicial.Location = new System.Drawing.Point(12, 240);
            this.botonLoginFormAskMooseInicial.Name = "botonLoginFormAskMooseInicial";
            this.botonLoginFormAskMooseInicial.Size = new System.Drawing.Size(75, 23);
            this.botonLoginFormAskMooseInicial.TabIndex = 0;
            this.botonLoginFormAskMooseInicial.Text = "Login";
            this.botonLoginFormAskMooseInicial.UseVisualStyleBackColor = true;
            this.botonLoginFormAskMooseInicial.Click += new System.EventHandler(this.botonLoginFormAskMooseInicial_Click);
            // 
            // botonPreguntasFormAskMoose
            // 
            this.botonPreguntasFormAskMoose.Location = new System.Drawing.Point(183, 240);
            this.botonPreguntasFormAskMoose.Name = "botonPreguntasFormAskMoose";
            this.botonPreguntasFormAskMoose.Size = new System.Drawing.Size(75, 23);
            this.botonPreguntasFormAskMoose.TabIndex = 1;
            this.botonPreguntasFormAskMoose.Text = "Preguntas";
            this.botonPreguntasFormAskMoose.UseVisualStyleBackColor = true;
            this.botonPreguntasFormAskMoose.Click += new System.EventHandler(this.botonPreguntasFormAskMoose_Click);
            // 
            // botonPerfilesFormAskMooseInicial
            // 
            this.botonPerfilesFormAskMooseInicial.Location = new System.Drawing.Point(310, 240);
            this.botonPerfilesFormAskMooseInicial.Name = "botonPerfilesFormAskMooseInicial";
            this.botonPerfilesFormAskMooseInicial.Size = new System.Drawing.Size(75, 23);
            this.botonPerfilesFormAskMooseInicial.TabIndex = 2;
            this.botonPerfilesFormAskMooseInicial.Text = "Perfiles";
            this.botonPerfilesFormAskMooseInicial.UseVisualStyleBackColor = true;
            this.botonPerfilesFormAskMooseInicial.Click += new System.EventHandler(this.botonPerfilesFormAskMooseInicial_Click);
            // 
            // botonSalirFormAskMoose
            // 
            this.botonSalirFormAskMoose.Location = new System.Drawing.Point(309, 13);
            this.botonSalirFormAskMoose.Name = "botonSalirFormAskMoose";
            this.botonSalirFormAskMoose.Size = new System.Drawing.Size(75, 23);
            this.botonSalirFormAskMoose.TabIndex = 3;
            this.botonSalirFormAskMoose.Text = "Salir";
            this.botonSalirFormAskMoose.UseVisualStyleBackColor = true;
            this.botonSalirFormAskMoose.Click += new System.EventHandler(this.botonSalirFormAskMoose_Click);
            // 
            // AskMooseFormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(397, 276);
            this.Controls.Add(this.botonSalirFormAskMoose);
            this.Controls.Add(this.botonPerfilesFormAskMooseInicial);
            this.Controls.Add(this.botonPreguntasFormAskMoose);
            this.Controls.Add(this.botonLoginFormAskMooseInicial);
            this.Name = "AskMooseFormInicial";
            this.Text = "AskMoose";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonLoginFormAskMooseInicial;
        private System.Windows.Forms.Button botonPreguntasFormAskMoose;
        private System.Windows.Forms.Button botonPerfilesFormAskMooseInicial;
        private System.Windows.Forms.Button botonSalirFormAskMoose;
    }
}


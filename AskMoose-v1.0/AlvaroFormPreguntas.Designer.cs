namespace AskMoose_v1._0
{
    partial class AlvaroFormPreguntas
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
            this.botonInicioFormAlvaroPreguntas = new System.Windows.Forms.Button();
            this.botonRespuestasEnFormPreguntas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonInicioFormAlvaroPreguntas
            // 
            this.botonInicioFormAlvaroPreguntas.Location = new System.Drawing.Point(197, 227);
            this.botonInicioFormAlvaroPreguntas.Name = "botonInicioFormAlvaroPreguntas";
            this.botonInicioFormAlvaroPreguntas.Size = new System.Drawing.Size(75, 23);
            this.botonInicioFormAlvaroPreguntas.TabIndex = 0;
            this.botonInicioFormAlvaroPreguntas.Text = "Inicio";
            this.botonInicioFormAlvaroPreguntas.UseVisualStyleBackColor = true;
            this.botonInicioFormAlvaroPreguntas.Click += new System.EventHandler(this.botonInicioFormAlvaroPreguntas_Click);
            // 
            // botonRespuestasEnFormPreguntas
            // 
            this.botonRespuestasEnFormPreguntas.Location = new System.Drawing.Point(13, 226);
            this.botonRespuestasEnFormPreguntas.Name = "botonRespuestasEnFormPreguntas";
            this.botonRespuestasEnFormPreguntas.Size = new System.Drawing.Size(75, 23);
            this.botonRespuestasEnFormPreguntas.TabIndex = 1;
            this.botonRespuestasEnFormPreguntas.Text = "Respuestas";
            this.botonRespuestasEnFormPreguntas.UseVisualStyleBackColor = true;
            this.botonRespuestasEnFormPreguntas.Click += new System.EventHandler(this.botonRespuestasEnFormPreguntas_Click);
            // 
            // AlvaroFormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.botonRespuestasEnFormPreguntas);
            this.Controls.Add(this.botonInicioFormAlvaroPreguntas);
            this.Name = "AlvaroFormPreguntas";
            this.Text = "Preguntas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonInicioFormAlvaroPreguntas;
        private System.Windows.Forms.Button botonRespuestasEnFormPreguntas;
    }
}
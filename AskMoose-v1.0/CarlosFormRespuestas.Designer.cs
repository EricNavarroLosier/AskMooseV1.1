namespace AskMoose_v1._0
{
    partial class CarlosFormRespuestas
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
            this.botonInicioFormRespuestas = new System.Windows.Forms.Button();
            this.botonVolverAPreguntasFormRespuestas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonInicioFormRespuestas
            // 
            this.botonInicioFormRespuestas.Location = new System.Drawing.Point(197, 227);
            this.botonInicioFormRespuestas.Name = "botonInicioFormRespuestas";
            this.botonInicioFormRespuestas.Size = new System.Drawing.Size(75, 23);
            this.botonInicioFormRespuestas.TabIndex = 0;
            this.botonInicioFormRespuestas.Text = "Inicio";
            this.botonInicioFormRespuestas.UseVisualStyleBackColor = true;
            this.botonInicioFormRespuestas.Click += new System.EventHandler(this.botonInicioFormRespuestas_Click);
            // 
            // botonVolverAPreguntasFormRespuestas
            // 
            this.botonVolverAPreguntasFormRespuestas.Location = new System.Drawing.Point(13, 227);
            this.botonVolverAPreguntasFormRespuestas.Name = "botonVolverAPreguntasFormRespuestas";
            this.botonVolverAPreguntasFormRespuestas.Size = new System.Drawing.Size(119, 23);
            this.botonVolverAPreguntasFormRespuestas.TabIndex = 1;
            this.botonVolverAPreguntasFormRespuestas.Text = "Volver a Preguntas";
            this.botonVolverAPreguntasFormRespuestas.UseVisualStyleBackColor = true;
            this.botonVolverAPreguntasFormRespuestas.Click += new System.EventHandler(this.botonVolverAPreguntasFormRespuestas_Click);
            // 
            // CarlosFormRespuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.botonVolverAPreguntasFormRespuestas);
            this.Controls.Add(this.botonInicioFormRespuestas);
            this.Name = "CarlosFormRespuestas";
            this.Text = "Respuestas";
            this.Load += new System.EventHandler(this.CarlosFormRespuestas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonInicioFormRespuestas;
        private System.Windows.Forms.Button botonVolverAPreguntasFormRespuestas;
    }
}
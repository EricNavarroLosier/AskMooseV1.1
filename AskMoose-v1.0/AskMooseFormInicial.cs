using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskMoose_v1._0
{
    public partial class AskMooseFormInicial : Form
    {
        public AskMooseFormInicial()
        {
            InitializeComponent();
        }

        private void botonPreguntasFormAskMoose_Click(object sender, EventArgs e)
        {
            Hide();
            AlvaroFormPreguntas ventanaPreguntas = new AlvaroFormPreguntas();
            ventanaPreguntas.Show();
        }

        private void botonPerfilesFormAskMooseInicial_Click(object sender, EventArgs e)
        {
            Hide();
            RodrigoFormPerfiles ventanaPerfiles = new RodrigoFormPerfiles();
            ventanaPerfiles.Show();
        }

        private void botonLoginFormAskMooseInicial_Click(object sender, EventArgs e)
        {
            Hide();
            EricFormLoginRegistro ventanaLoginRegistro = new EricFormLoginRegistro();
            ventanaLoginRegistro.Show();
        }

        private void botonSalirFormAskMoose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

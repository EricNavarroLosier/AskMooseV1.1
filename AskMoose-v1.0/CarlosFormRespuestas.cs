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
    public partial class CarlosFormRespuestas : Form
    {
        public CarlosFormRespuestas()
        {
            InitializeComponent();
        }

        private void botonInicioFormRespuestas_Click(object sender, EventArgs e)
        {
            Hide();
            AskMooseFormInicial ventanaInicio = new AskMooseFormInicial();
            ventanaInicio.Show();
        }

        private void botonVolverAPreguntasFormRespuestas_Click(object sender, EventArgs e)
        {
            Hide();
            AlvaroFormPreguntas ventanaPreguntas = new AlvaroFormPreguntas();
            ventanaPreguntas.Show();
        }
    }
}

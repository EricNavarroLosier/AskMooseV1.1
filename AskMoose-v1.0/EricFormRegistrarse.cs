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
    public partial class EricFormRegistrarse : Form
    {
        public EricFormRegistrarse()
        {
            InitializeComponent();
        }

        private void botonInicioDesdeFormRegistro_Click(object sender, EventArgs e)
        {
            Hide();
            AskMooseFormInicial ventanaPrincipal = new AskMooseFormInicial();
            ventanaPrincipal.Show();
        }

        private void botonAtrasFormRegistro_Click(object sender, EventArgs e)
        {
            Hide();
            EricFormLoginRegistro ventanaLoginRegistro = new EricFormLoginRegistro();
            ventanaLoginRegistro.Show();
        }
    }
}

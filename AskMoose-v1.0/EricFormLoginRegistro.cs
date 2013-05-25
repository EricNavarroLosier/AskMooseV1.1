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
    public partial class EricFormLoginRegistro : Form
    {
        public EricFormLoginRegistro()
        {
            InitializeComponent();
        }

        private void botonInicioFormLoginRegistro_Click(object sender, EventArgs e)
        {
            Hide();
            AskMooseFormInicial ventanaPrincipal = new AskMooseFormInicial();
            ventanaPrincipal.Show();
        }

        private void botonRegistrateFormLoginRegistro_Click(object sender, EventArgs e)
        {
            Hide();
            EricFormRegistrarse ventanaRegistrarse = new EricFormRegistrarse();
            ventanaRegistrarse.Show();
        }

        
    }
}

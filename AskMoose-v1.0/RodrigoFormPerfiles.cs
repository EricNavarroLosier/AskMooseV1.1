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
    public partial class RodrigoFormPerfiles : Form
    {
        public RodrigoFormPerfiles()
        {
            InitializeComponent();
        }

        private void botonInicioDesdeFormPerfiles_Click(object sender, EventArgs e)
        {
            Hide();
            AskMooseFormInicial ventanaInicio = new AskMooseFormInicial();
            ventanaInicio.Show();
        }
    }
}

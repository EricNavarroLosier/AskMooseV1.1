using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Importo las librerías de MySql
using MySql.Data.MySqlClient;

namespace AskMoose_v1._0
{
    public partial class EricFormLoginRegistro : Form
    {
        //String que contendrá la cadena de conexión (esta cadena viene por defecto desde nuestros servidores con los usuarios y contraseñas que tenemos en ese momento )
        private String str_connection;
        //Conector de MySql, interactuará entre nuestro programa y nuesta base de datos y creará un puente entre ambas
        private MySqlConnection connector;
        //Contiene los datos que contiene nuestra tabla a nivel de programa
        private DataSet data;
        //Adaptador de MySql que hará la comunicación entre el DataSet y nuestra base de datos
        private MySqlDataAdapter adapter;

        private MySqlDataReader result;
        
        
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos las librería de MySql
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace AskMoose_v1._0
{
    public partial class CarlosFormRespuestas : Form
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


        public void realizarConexion() {
            try
            {
                //Inicializamos la cadena de conexion ( servidor, base de datos que vamos a usar, usuario, contraseña y puerto)
                str_connection = @"Server=db4free.net;     Database=respuestasprueba;      Uid =cfvillahermosa;        Pwd=askmoose;       Port= 3306;";
                //Construimos el conector a partir de la cadena de conexión anterior
                connector = new MySqlConnection(str_connection);
                //Abrimos el conector para iniciar la comunicación entre la base de datos y el programa
                connector.Open();
                //Mostramos un mensjae para saber que hemos establecido la conexión
                MessageBox.Show("Conexión establecida");

                adapter = new MySqlDataAdapter("SELECT * FROM respuestasprueba.respuestas",connector);

                data = new DataSet();
                adapter.Fill(data);
                DataTable tabla = new DataTable();
                if (tabla.Rows.Count > 0) {
                    MessageBox.Show(tabla.Rows[0][2].ToString());
                }

                
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }


        public CarlosFormRespuestas()
        {
            InitializeComponent();
        }

        private void botonInicioFormRespuestas_Click(object sender, EventArgs e)
        {
            Hide();
            AskMooseFormInicial ventanaInicio = new AskMooseFormInicial();
            connector.Close();
            MessageBox.Show("Conexión finalizada");
            ventanaInicio.Show();
        }

        private void botonVolverAPreguntasFormRespuestas_Click(object sender, EventArgs e)
        {
            Hide();
            AlvaroFormPreguntas ventanaPreguntas = new AlvaroFormPreguntas();
            connector.Close();
            MessageBox.Show("Conexión finalizada");
            ventanaPreguntas.Show();
        }

        private void CarlosFormRespuestas_Load(object sender, EventArgs e)
        {
            realizarConexion();
        }
    }
}

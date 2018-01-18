using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DINT_F_P
{
    public partial class TwitClientMain : Form
    {

        private string Usuario { get; set; }
        private string Contrasenya { get; set; }
        private MySqlConnectionStringBuilder build = null;
        private MySqlConnection conexion = null;

        public TwitClientMain()
        {
            InitializeComponent();
            //Bloque de conexión a la base de datos
            conectarBBDD(ref build, ref conexion);
            //desconectarBBDD(ref conexion);
            
        }
        public void conectarBBDD(ref MySqlConnectionStringBuilder build, ref MySqlConnection conexion) {

            try
            {
                build = new MySqlConnectionStringBuilder();
                build.Server = "localhost";
                build.UserID = "root";
                build.Password = "12345";
                build.Database = "twittclient";
                conexion = new MySqlConnection(build.ToString());
                conexion.Open();
                MessageBox.Show("Conectadito");  
            }
            catch (MySqlException e) { e.ToString();  }
        }
        public void desconectarBBDD(ref MySqlConnection conexion) {

            conexion.Close();
            //MessageBox.Show("Desconectadito");
        }
   

        //CÓDIGO RELATIVO A LA PÁGINA DE LOGIN
        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuario = textBoxUsuario.Text;
            Contrasenya = textBoxContrasenya.Text;
            
            string user = Usuario;
            string sql = "SELECT * from usuarios WHERE usuario_twitter=@USER";
            MySqlCommand comand = new MySqlCommand(sql,conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader reader = comand.ExecuteReader();

            //Si el user existe y las comprobaciones son correctas, vamos al TIMELINE
            if (reader.Read()){
                if (reader["contrasena"].ToString() == Contrasenya)
                {
                    ControlPaginas.SelectedTab = UserMainTimeline;
                    richTextBoxCajaTwit.Text = "twitt as " + reader["usuario_twitter"].ToString();
                    reader.Close();
                }
                else {
                    MessageBox.Show("Usuario/contraeña incorrectos");
                    reader.Close();
                }
                
            }
            else {
                MessageBox.Show("Usuario/contraeña incorrectos");
                reader.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //button for create a twitt

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Va a la página de notificaciones
        private void pictureBoxNotifications_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastNotifications;
        }

        //Va a la página principal
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Main;
        }

        //Va a la página Last twitts
        private void pictureBoxLastTwits_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastTwits;
        }

        private void pictureBoxConfig_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastTwits;
        }

        //FIN DE CÓDIGO RELATIVO A LA PÁGINA PRINCIPAL
    }


}

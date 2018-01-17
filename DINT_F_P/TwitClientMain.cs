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
        private MySqlCommand comand = null;
      

        public TwitClientMain()
        {
            InitializeComponent();
            //Bloque de conexión a la base de datos
            try {
                build = new MySqlConnectionStringBuilder();
                build.Server = "localhost";
                build.UserID = "root";
                build.Password = "12345";
                build.Database = "twittclient";
                conexion = new MySqlConnection(build.ToString());
                conexion.Open();
            }
            catch (MySqlException e) { e.ToString(); }  
        }

        //CÓDIGO RELATIVO A LA PÁGINA PRINCIPAL
        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuario = textBoxUsuario.Text;
            Contrasenya = textBoxContrasenya.Text;
            ControlPaginas.SelectedTab = UserMainTimeline;
            comand = conexion.CreateCommand();



            richTextBoxCajaTwit.Text = "Twit as "+Usuario;

            //TODO: colocar el control para que no se puedan loguear sin cuenta.

            //if(select usuario not in database){Dialog"No estás registrado, amigo"}
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

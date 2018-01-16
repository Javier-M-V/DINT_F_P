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

        private string usuario { get; set; }
        private string contrasenya { get; set; }
        private MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        //build.Server = "localhost";


        public TwitClientMain()
        {
            InitializeComponent();
            
        }

        //CÓDIGO RELATIVO A LA PÁGINA PRINCIPAL
        private void button1_Click_1(object sender, EventArgs e)
        {
            usuario = textBoxUsuario.Text;
            contrasenya = textBoxContrasenya.Text;
            ControlPaginas.SelectedTab = UserMainTimeline;
            richTextBoxCajaTwit.Text = "Twit as "+usuario;
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

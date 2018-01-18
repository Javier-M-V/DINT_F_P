using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DINT_F_P{

    public partial class TwitClientMain : Form {

        private string Usuario { get; set; }
        private string Contrasenya { get; set; }
        private MySqlConnectionStringBuilder build = null;
        private MySqlConnection conexion = null;

        public TwitClientMain(){

            InitializeComponent();
            conectarBBDD(ref build, ref conexion);   
        }
        public void conectarBBDD(ref MySqlConnectionStringBuilder build, ref MySqlConnection conexion) {

            try{

                build = new MySqlConnectionStringBuilder();
                build.Server = "localhost";
                build.UserID = "root";
                build.Password = "12345";
                build.Database = "twittclient";
                conexion = new MySqlConnection(build.ToString());
                conexion.Open();
                MessageBox.Show("Conectadito");  
            }
            catch (MySqlException e) { e.ToString(); MessageBox.Show("Error de conexión a BBDD"); }
        }
        public void desconectarBBDD(ref MySqlConnection conexion) {

            try{

                conexion.Close();
            }
            catch (MySqlException e) { e.ToString(); }
        }
        //EVENTO AL CIERRE DE LA APLICACIÓN: cerrar la conexión a BBDD
        private void TwitClientMain_FormClosed(object sender, FormClosedEventArgs e){

            desconectarBBDD(ref conexion);
        }

        //CÓDIGO RELATIVO A LA PÁGINA DE LOGIN
        private void customButton1Login_Click(object sender, EventArgs e){

            Usuario = textBoxUsuario.Text;
            Contrasenya = textBoxContrasenya.Text;

            string user = Usuario;
            string sql = "SELECT * from usuarios WHERE usuario_twitter=@USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader reader = comand.ExecuteReader();

            //Si el user existe se ejecuta el bloque
            if (reader.Read()){
                //si en la BBDD la contraseña coincide se ejecuta el bloque
                if (reader["contrasena"].ToString() == Contrasenya){ 

                    ControlPaginas.SelectedTab = UserMainTimeline;
                    //Fijamos el texto de labels  y textos dinamicamente
                    richTextBoxCajaTwit.Text = "twitt as " + reader["usuario_twitter"].ToString();
                    labelLastTwits.Text = reader["usuario_twitter"].ToString() + " last twitts";
                    labelLastNotifications.Text = reader["usuario_twitter"].ToString() + " last notifications";
                    reader.Close();
                }
                else{

                    MessageBox.Show("Usuario/contraeña incorrectos");
                    reader.Close();
                }
            }
            else{

                MessageBox.Show("Usuario/contraeña incorrectos");
                reader.Close();
            }
        }

        //Borra el contenido al hacer clic en la caja
        private void textBoxContrasenya_Click(object sender, EventArgs e){

            textBoxContrasenya.Text = "";
        }
        //Borra el contenido al hacer clic en la caja
        private void textBoxUsuario_Click(object sender, EventArgs e){

            textBoxUsuario.Text =  "";
        }
        //FIN DE CÓDIGO RELATIVO A LA PÁGINA DE LOGIN



        //CÓDIGO RELATIVO AL TIMELINE
        private void pictureBox1_Click(object sender, EventArgs e){

            //button for create a twitt

        }

        //Va a la página de notificaciones
        private void pictureBoxNotifications_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastNotifications;
        }

        //Va a la página principal
        private void pictureBoxHome_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastTwits;
        }

        //Va a la página Last twitts
        private void pictureBoxLastTwits_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastTwits;
        }

        private void pictureBoxConfig_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastTwits;
        }

        //Si hacemos focus en la caja, borramos el contenido
        private void richTextBoxCajaTwit_Click(object sender, EventArgs e){

            richTextBox1.Text = "";
        }

        //FIN DE CÓDIGO RELATIVO AL TIMELINE  
    }
}

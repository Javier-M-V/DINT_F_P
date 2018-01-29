using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TuitBox;
using System.Drawing;
using System.Globalization;

namespace DINT_F_P{

    public partial class TwitClientMain : Form {

        private string Usuario { get; set; }
        private string Contrasenya { get; set; }
        private MySqlConnectionStringBuilder build = null;
        private MySqlConnection conexion = null;

        public TwitClientMain(){

            InitializeComponent();
            ConectarBBDD(ref build, ref conexion);   
        }
        public void ConectarBBDD(ref MySqlConnectionStringBuilder build, ref MySqlConnection conexion) {

            try{

                build = new MySqlConnectionStringBuilder();
                build.Server = "localhost";
                build.UserID = "root";
                build.Password = "12345";
                build.Database = "twittclient";
                conexion = new MySqlConnection(build.ToString());
                conexion.Open(); 
            }
            catch (MySqlException) { MessageBox.Show("Error de conexión a BBDD"); }
        }
        public void DesconectarBBDD(ref MySqlConnection conexion) {

            try{

                conexion.Close();
            }
            catch (MySqlException e) { e.ToString(); }
        }
        //EVENTO AL CIERRE DE LA APLICACIÓN: cerrar la conexión a BBDD
        private void TwitClientMain_FormClosed(object sender, FormClosedEventArgs e){

            DesconectarBBDD(ref conexion);
        }

        //CÓDIGO RELATIVO A LA PÁGINA DE LOGIN
        private void CustomButton1Login_Click(object sender, EventArgs e){

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

                    ControlPaginas.SelectedTab = Timeline;
                    //Fijamos el texto de labels  y textos dinamicamente
                    richTextBoxCajaTwit.Text = "twitt as " + reader["usuario_twitter"].ToString();
                    labelLastTwits.Text = reader["usuario_twitter"].ToString() + " last twitts";
                    labelLastNotifications.Text = reader["usuario_twitter"].ToString() + " last notifications"; reader.Close();
                    //cargamos todos los tuits necesarios en las páginas correspondientes
                    reader.Close();
                    reader = RescateTimeline(user);
                    while (reader.Read())
                    {

                        CajaTwitt.UserControl1 cajita = new CajaTwitt.UserControl1();
                        cajita.ForeColor = Color.Black;
                        cajita.SetTuit(reader["mensaje"].ToString());
                        cajita.SetRets(Int32.Parse(reader["num_rets"].ToString()));
                        cajita.SetFavs(Int32.Parse(reader["num_favs"].ToString()));
                        cajita.SetUser(reader["user_emisor"].ToString());
                        flowLayoutPanelTwits.Controls.Add(cajita); 
                    }
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
        private MySqlDataReader RescateTimeline(string user) {

            string sql = "SELECT * from mensajes WHERE user_emisor IN (SELECT user_seguido FROM seguimiento WHERE user_sigue = @USER) ORDER BY fecha";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", user);
            MySqlDataReader readertimeline = comand.ExecuteReader();
       
            return readertimeline;
        }

        private MySqlDataReader RescateTwittsSelfUsuario (string user) {

            string sql = "SELECT * from mensajes WHERE user_emisor = @USER ORDER BY fecha";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", user);
            MySqlDataReader readermensajesuser = comand.ExecuteReader();

            return readermensajesuser;
        }

        //Borra el contenido al hacer clic en la caja
        private void TextBoxContrasenya_Click(object sender, EventArgs e){

            textBoxContrasenya.Text = "";
        }
        //Borra el contenido al hacer clic en la caja
        private void TextBoxUsuario_Click(object sender, EventArgs e){

            textBoxUsuario.Text =  "";
        }
            //FIN DE CÓDIGO RELATIVO A LA PÁGINA DE LOGIN


        //CÓDIGO RELATIVO AL TIMELINE
        private void PictureBox1_Click(object sender, EventArgs e){

            //button for create a twitt

        }

        //Va a la página de notificaciones
        private void PictureBoxNotifications_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastNotifications;
        }

        //Va a la página principal
        private void PictureBoxHome_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastTwits;
        }

        //Va a la página Last twitts
        private void PictureBoxLastTwits_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastTwits;
        }

        private void PictureBoxConfig_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastTwits;
        }

        //Si hacemos focus en la caja, borramos el contenido
        private void RichTextBoxCajaTwit_Click(object sender, EventArgs e){

            richTextBox1.Text = "";
        }

        //Botón de tuitear
        private void ButtonTwittIt_Click(object sender, EventArgs e)
        {
            //inserción en BBDD
            string sql = "Insert INTO mensajes VALUES(@USER,@RECEPTOR,@DATE,@MENSAJE,@FAVS,@RETS)";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            comand.Parameters.AddWithValue("@RECEPTOR", "");
            comand.Parameters.AddWithValue("@DATE", DateTime.Now.ToString("yyyy-MM-dd h:mm:ss"));
            comand.Parameters.AddWithValue("@MENSAJE", richTextBoxCajaTwit.Text);
            comand.Parameters.AddWithValue("@FAVS", 0);
            comand.Parameters.AddWithValue("@RETS", 0);

            //refresco del flowlayout e inserción del tuit en la vista
            CajaTwitt.UserControl1 cajita = new CajaTwitt.UserControl1();
            cajita.ForeColor = Color.Black;
            cajita.SetTuit(richTextBoxCajaTwit.Text);
            cajita.SetRets(0);
            cajita.SetFavs(0);
            cajita.SetUser(Usuario);
            flowLayoutPanelTwits.Controls.Add(cajita);
        }           
    }           //FIN DE CÓDIGO RELATIVO AL TIMELINE  
}

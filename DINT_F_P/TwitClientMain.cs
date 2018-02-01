using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TuitBox;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace DINT_F_P{

    public partial class TwitClientMain : Form {

        private string Usuario { get; set; }
        private string Contrasenya { get; set; }
        private MySqlConnectionStringBuilder build = null;
        private MySqlConnection conexion = null;

        public TwitClientMain(){

            InitializeComponent();
            ConectarBBDD(ref build, ref conexion);
            /*Usuario = "@miguel";
            SubirAvatar("C:\\Users\\Alumno\\source\\repos\\DINT_F_P\\DINT_F_P\\bin\\Debug\\images.jpg");*/

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
        //conversión de ruta de una foto a byte[]
        private byte[] FotoABytes(string ruta)
        {
            FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] fotobytes = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return fotobytes;
        }
        //conversión de bytes[] a blob para subir a BBDD
        private void SubirAvatar(string ruta)
        {
            byte[] foto = FotoABytes(ruta);
            string sql = "UPDATE usuarios SET foto = @foto WHERE usuario_twitter=@USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.Add("@foto", MySqlDbType.MediumBlob, foto.Length).Value = foto;
            comand.Parameters.AddWithValue("@USER", Usuario);
            comand.ExecuteNonQuery();
        }

        //CÓDIGO RELATIVO A LA PÁGINA DE LOGIN
        private void CustomButton1Login_Click(object sender, EventArgs e){

            Usuario = textBoxUsuario.Text;
            Contrasenya = textBoxContrasenya.Text;
            string sql = "SELECT * from usuarios WHERE usuario_twitter=@USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader Reader = comand.ExecuteReader();
            //MessageBox.Show(Reader[0].ToString());
            //Si el user existe se ejecuta el bloque
            if (Reader.Read()){
                //si en la BBDD la contraseña coincide se ejecuta el bloque
                if (Reader["contrasena"].ToString() == Contrasenya){ 

                    ControlPaginas.SelectedTab = Timeline;
                    //Fijamos el texto de labels  y textos dinamicamente
                    richTextBoxCajaTwit.Text = "twitt as " + Reader["usuario_twitter"].ToString();
                    labelLastTwits.Text = Reader["usuario_twitter"].ToString() + " last twitts";
                    labelLastNotifications.Text = Reader["usuario_twitter"].ToString() + " last notifications";
                    labelEstadoUser.Text = Reader["estado"].ToString();
                    byte[] avatarByte = (byte[])Reader["foto"];
                    MemoryStream ms = new MemoryStream(avatarByte);
                    Image fotoavatar = Image.FromStream(ms);
                    pictureBoxFotoPerfilTImeline.Image = fotoavatar;
                    pictureBoxPerfilUserFoto.Image = fotoavatar;
                    labelEstadUserPerfil.Text = Reader["estado"].ToString();
                    labelNombreUserperfil.Text = Reader["usuario_twitter"].ToString();                 
                    //cargamos todos los tuits necesarios en las páginas correspondientes
                    Reader.Close();
                    RescateTimeline(Usuario);
                    RescateTwittsSelfUsuario(Usuario);
                }
                else{

                    MessageBox.Show("Usuario/contraeña incorrectos");
                    Reader.Close();

                }
            }
            else{

                MessageBox.Show("Usuario/contraeña incorrectos");
                Reader.Close();
            }
            
        }
        //Comportamiento de tecla enter en el login
        private void customButton1Login_Enter(object sender, EventArgs e)
        {
            CustomButton1Login_Click(sender, e);
        }

        //rellena el flowlayout con los tuits de los usuarios que sigue el usuario logueado
        private void RescateTimeline(string User) {

            string sql = "SELECT * from mensajes WHERE user_emisor IN (SELECT user_seguido FROM seguimiento WHERE user_sigue = @USER) ORDER BY fecha";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", User);
            MySqlDataReader reader = comand.ExecuteReader();
            
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

        //rellena el flowlayout con los tuits del usuario logueado
        private void RescateTwittsSelfUsuario (string Usuario) {
            string sql = "SELECT * from mensajes WHERE user_emisor = @USER ORDER BY fecha";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                CajaTwitt.UserControl1 cajita = new CajaTwitt.UserControl1();
                cajita.ForeColor = Color.Black;
                cajita.SetTuit(reader["mensaje"].ToString());
                cajita.SetRets(Int32.Parse(reader["num_rets"].ToString()));
                cajita.SetFavs(Int32.Parse(reader["num_favs"].ToString()));
                cajita.SetUser(reader["user_emisor"].ToString());
                flowLayoutPanelLastTuits.Controls.Add(cajita);
            }
            reader.Close();
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

        //Va a la página de notificaciones
        private void PictureBoxNotifications_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastNotifications;
        }

        //Va a la página Last twitts
        private void PictureBoxLastTwits_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastTwits;
            
        }

        private void PictureBoxConfig_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = tabPagePerfilUser;
        }

        //Si hacemos focus en la caja, borramos el contenido
        private void RichTextBoxCajaTwit_Click(object sender, EventArgs e){

           // richTextBox1.Text = "";
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
            comand.ExecuteNonQuery();

            //refresco del flowlayout e inserción del tuit en la vista
            flowLayoutPanelTwits.Controls.Clear();
            CajaTwitt.UserControl1 cajita = new CajaTwitt.UserControl1();
            cajita.ForeColor = Color.Black;
            cajita.SetTuit(richTextBoxCajaTwit.Text);
            cajita.SetRets(0);
            cajita.SetFavs(0);
            cajita.SetUser(Usuario);
            flowLayoutPanelTwits.Controls.Add(cajita);
            RescateTimeline(Usuario);
            flowLayoutPanelLastTuits.Controls.Clear();
            RescateTwittsSelfUsuario(Usuario);
        }
 
            //FIN DE CÓDIGO RELATIVO AL TIMELINE

        //BOTONES DE CAMBIO DE PANTALLA
        //CÓDIGO RELATIVO A LAST TUITS
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Timeline;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastNotifications;
        }

        private void pictureBoxuser2_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = tabPagePerfilUser;
        }
               //FIN DE CÓDIGO RELATIVO A LAST TUITS
        //CODIGO DE NOTIFICATIONS
        private void pictureBoxtimeline3_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastTwits;
        }

        private void pictureBoxhome3_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Timeline;
        }

        private void pictureBoxuser3_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = tabPagePerfilUser;
        }
                //FIN DE CODIGO DE NOTIFICATIONS
        //CODIGO DE PERFIL
        private void pictureBoxHome4_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Timeline;
        }

        private void pictureBoxLasttuits4_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastTwits;
        }

        private void pictureBoxNotifications4_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastNotifications;
        }



        private void Editar_Click(object sender, EventArgs e)
        {
            //editar perfil
        }

        //logout text
        private void logoutLabel_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Main;
            Usuario = "";
            Contrasenya = "";
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            labelLogout.ForeColor = Color.DarkGray;
        }

        private void labelLogout_MouseLeave(object sender, EventArgs e)
        {
            labelLogout.ForeColor = Color.Black;
        }
        //FIN DE CODIGO DE PERFIL
    }
}

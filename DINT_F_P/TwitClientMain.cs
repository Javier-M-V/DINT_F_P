using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

namespace DINT_F_P{


    /// <summary>
    /// Formulario principal.
    /// Contiene las funciones básicas de comportamiento.
    /// </summary>
    public partial class TwitClientMain : Form {

        private string Usuario { get; set; }
        private string Contrasenya { get; set; }
        private MySqlConnectionStringBuilder build = null;
        private MySqlConnection conexion = null;

        /// <summary>
        /// Constructor del formulario.
        /// Inicializa la conexión con la BBDD.
        /// </summary>
        public TwitClientMain(){

            InitializeComponent();
            ConectarBBDD(ref build, ref conexion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        /// <summary>
        /// Constructor del formulario.
        /// Inicializa la conexión con la BBDD.
        /// </summary>
        /// <param name="conexion">conexion es la referencia a la base de datos mysql.</param>
        /// <param name="build">build es la referencia al builder constructor del string para conectase a la BBDD.</param>

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

        /// <summary>
        /// Desconecta de la BBDD.
        /// <param name="conexion">conexion es la referencia a la base de datos mysql.</param>
        /// </summary>
        public void DesconectarBBDD(ref MySqlConnection conexion) {

            try{

                conexion.Close();
            }
            catch (MySqlException e) { e.ToString(); }
        }

        /// <summary>
        /// Llama a la desconexión de la BBDD como respuesta al cierrde de la App.
        /// </summary>
        private void TwitClientMain_FormClosed(object sender, FormClosedEventArgs e){

            DesconectarBBDD(ref conexion);
        }

        //CÓDIGO RELATIVO A LA PÁGINA DE LOGIN

        /// <summary>
        /// Entra en la página principal y carga todos los datos dinámicos del usuario.
        /// </summary>
        private void CustomButton1Login_Click(object sender, EventArgs e){

            Usuario = textBoxUsuario.Text;
            Contrasenya = textBoxContrasenya.Text;

            string sql = "SELECT contrasena from usuarios WHERE usuario_twitter=@USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader Reader = comand.ExecuteReader();
            if (Reader.Read()){
                
                if (Reader["contrasena"].ToString() == Contrasenya){
                    Reader.Close();
                    ControlPaginas.SelectedTab = Timeline;//Entamos en la pantalla principal
                    RescateInfoDinamica(Usuario);//cargamos bloque a bloque todos los datos del usuario
                    RescateTimeline(Usuario);//buscamos los tuits de los seguidos por el usuario
                    RescateTwittsSelfUsuario(Usuario); //buscamos los tuits del propio usuario
                    RescateNotifications();//buscamos las notificaciones
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
        /// <summary>
        /// Rescatamos los datos del usuario en todas las pantallas.
        /// </summary>
        private void RescateInfoDinamica (string Usuario){

            byte[] avatarByte = null;
            string sql = "SELECT * from usuarios WHERE usuario_twitter=@USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader reader = comand.ExecuteReader();

            if (reader.Read()) {

                richTextBoxCajaTwit.Text = "twitt as " + reader["usuario_twitter"].ToString();
                labelLastNotifications.Text = reader["usuario_twitter"].ToString() + " last notifications";
                labelEstadoUser.Text = reader["estado"].ToString();
                labelEstadUserPerfil.Text = reader["estado"].ToString();
                labelNombreUserperfil.Text = reader["usuario_twitter"].ToString();
                try{

                    avatarByte = (byte[])reader["foto"];
                    MemoryStream ms = new MemoryStream(avatarByte);
                    Image fotoavatar = Image.FromStream(ms);
                    pictureBoxFotoPerfilTImeline.Image = fotoavatar;
                    pictureBoxPerfilUserFoto.Image = fotoavatar;

                } catch (InvalidCastException) {

                    pictureBoxPerfilUserFoto.Image = null;//TODO: METER IMAGEN POR DEFECTO
                }

                reader.Close();
                CargarEstadisticas();
            }          
        }

        /// <summary>
        /// Rellena el flowlayout de los tuits de los seguidos por el usuario.
        /// 
        /// </summary>
        private void RescateTimeline(string User) {

            byte[] avatarByte = null;
            Image fotoavatar = null;
            MemoryStream ms;
            string sql = "SELECT mensaje,num_rets,num_favs,user_emisor,foto FROM mensajes, usuarios WHERE user_emisor IN (SELECT user_seguido FROM seguimiento WHERE user_sigue = @USER) AND mensajes.user_emisor =usuarios.usuario_twitter ORDER BY fecha";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", User);
            MySqlDataReader reader = comand.ExecuteReader();
            
            while (reader.Read())
            {
                CajaTwitt.UserControl1 cajita = new CajaTwitt.UserControl1(ref conexion);
                cajita.ForeColor = Color.Black;
                cajita.SetTuit(reader["mensaje"].ToString());
                cajita.SetRets(Int32.Parse(reader["num_rets"].ToString()));
                cajita.SetFavs(Int32.Parse(reader["num_favs"].ToString()));
                cajita.SetUser(reader["user_emisor"].ToString());
                try
                {                   
                    avatarByte = (byte[])reader["foto"];
                    ms = new MemoryStream(avatarByte);
                    fotoavatar = Image.FromStream(ms, false, false);
                }
                catch (InvalidCastException){

                    pictureBoxPerfilUserFoto.Image = null;//TODO: METER IMAGEN POR DEFECTO
                }
                cajita.SetFoto(fotoavatar);
                flowLayoutPanelTwits.Controls.Add(cajita);
            }
            reader.Close();  
        }

        /// <summary>
        /// Rescata de la BBDD los tuits del propio usuario.
        /// </summary>
        private void RescateTwittsSelfUsuario (string Usuario) {
            byte[] avatarByte = null;
            Image fotoavatar = null;
            MemoryStream ms;
            string sql = "SELECT mensaje, num_rets,num_favs,user_emisor,foto from mensajes,usuarios WHERE user_emisor = @USER AND user_emisor = usuario_twitter ORDER BY fecha DESC";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                CajaTwitt.UserControl1 cajita = new CajaTwitt.UserControl1(ref conexion);
                cajita.ForeColor = Color.Black;
                cajita.SetTuit(reader["mensaje"].ToString());
                cajita.SetRets(Int32.Parse(reader["num_rets"].ToString()));
                cajita.SetFavs(Int32.Parse(reader["num_favs"].ToString()));
                cajita.SetUser(reader["user_emisor"].ToString());
                try
                {
                    avatarByte = (byte[])reader["foto"];
                    ms = new MemoryStream(avatarByte);
                    fotoavatar = Image.FromStream(ms, false, false);
                }
                catch (InvalidCastException)
                {

                    pictureBoxPerfilUserFoto.Image = null;//TODO: METER IMAGEN POR DEFECTO
                }
                cajita.SetFoto(fotoavatar);
                cajita.Enabled = false; //evitamos que el user se autohaga retuit o fav. A lo mejor en twitter se puede, pero da igual, no me gusta y lo quito.
                flowLayoutPanelLastTuits.Controls.Add(cajita);
            }
            reader.Close();
        }

        /// <summary>
        /// Rescata de la BBDD las notificaciones guardadas.
        /// </summary>
        private void RescateNotifications(){

            byte[] avatarByte = null;
            Image fotoavatar = null;
            MemoryStream ms;
            String sql = "SELECT mensaje, foto FROM avisos, usuarios WHERE user_destinatario = @USER AND user_disparador = usuario_twitter";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                CajaNot.CajaNotificaciones cajita = new CajaNot.CajaNotificaciones();
                cajita.ForeColor = Color.Black;
                cajita.SetMensaje(reader["mensaje"].ToString());
                try
                {
                    avatarByte = (byte[])reader["foto"];
                    ms = new MemoryStream(avatarByte);
                    fotoavatar = Image.FromStream(ms, false, false);
                }
                catch (InvalidCastException)
                {

                    pictureBoxPerfilUserFoto.Image = null;//TODO: METER IMAGEN POR DEFECTO
                }
                cajita.SetFoto(fotoavatar);
                
                flowLayoutPanelNotifications.Controls.Add(cajita);
            }
            reader.Close();
        }

        /// <summary>
        /// Borra el texto de la caja al hacer clic.
        /// </summary>
        private void TextBoxContrasenya_Click(object sender, EventArgs e){

            textBoxContrasenya.Text = "";
        }
        /// <summary>
        /// Borra el texto de la caja al hacer clic.
        /// </summary>
        private void TextBoxUsuario_Click(object sender, EventArgs e){

            textBoxUsuario.Text =  "";
        }
        //FIN DE CÓDIGO RELATIVO A LA PÁGINA DE LOGIN


        //CÓDIGO RELATIVO AL TIMELINE
        /// <summary>
        /// Lleva a Notificaciones.
        /// </summary>
        private void PictureBoxTuitear_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = LastNotifications;
        }

        /// <summary>
        /// Lanza el form para tuitear.
        /// </summary>
        private void PictureBoxLastTwits_Click(object sender, EventArgs e){

            VentanaTuit();
        }

        /// <summary>
        /// Lleva al perfil de usuario.
        /// </summary>
        private void PictureBoxConfig_Click(object sender, EventArgs e){

            ControlPaginas.SelectedTab = tabPagePerfilUser;
        }

        /// <summary>
        /// Borra el texto del richtextbox al hacer clic.
        /// </summary>
        private void RichTextBoxCajaTwit_Click(object sender, EventArgs e){

           // richTextBox1.Text = "";
        }

        /// <summary>
        /// Evento que responde al botón de tuitear.
        /// </summary>
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
            CajaTwitt.UserControl1 cajita = new CajaTwitt.UserControl1(ref conexion);
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


        //BOTONES DE CAMBIO DE PANTALLA
        /// <summary>
        /// Evento que responde al botón de tuitear.
        /// </summary>
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Timeline;
        }

        /// <summary>
        /// Evento que responde al botón de tuitear.
        /// </summary>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastNotifications;
        }

        /// <summary>
        /// Evento que responde al botón de tuitear.
        /// </summary>
        private void PictureBoxuser2_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = tabPagePerfilUser;
        }

        /// <summary>
        /// Respuesta de la tecla enter en el login.
        /// Nombre de usuario.
        /// </summary>
        private void TextBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustomButton1Login_Click(sender, e);
            }
        }

        /// <summary>
        /// Respuesta de la tecla enter en el login.
        /// Contraseña.
        /// </summary>
        private void TextBoxContrasenya_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustomButton1Login_Click(sender, e);
            }
        }

        //FIN DE CÓDIGO RELATIVO AL TIMELINE


        //CODIGO DE NOTIFICATIONS
        //BOTONES DE CAMBIO DE PANTALLA
        /// <summary>
        /// Llama a la función de generar formulario para hacer tuit.
        /// </summary>
        private void PictureBoxtimeline3_Click(object sender, EventArgs e)
        {
            PictureBoxTuitear_Click(sender, e);
        }

        /// <summary>
        /// Va al timeline.
        /// </summary>
        private void PictureBoxhome3_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Timeline;
        }

        /// <summary>
        /// Va al perfil.
        /// </summary>
        private void PictureBoxuser3_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = tabPagePerfilUser;
        }
        //FIN DE CODIGO DE NOTIFICATIONS



        //CODIGO DE PERFIL
        /// <summary>
        /// Va al timeline.
        /// </summary>
        private void PictureBoxHome4_Clic(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Timeline;
        }

        /// <summary>
        /// Evento que responde al botón de tuitear.
        /// </summary>
        private void PictureBoxLasttuits4_Clic(object sender, EventArgs e)
        {
            VentanaTuit();
        }

        /// <summary>
        /// Va a notificaciones.
        /// </summary>
        private void PictureBoxNotifications4_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = LastNotifications;
        }


        /// <summary>
        /// Evento que responde al botón de editar el perfil.
        /// Abre el formulario para editar y hace update.
        /// </summary>
        private void Editar_Click(object sender, EventArgs e)
        {
            FormEditar editar = new FormEditar();
            editar.ShowDialog();
            Image nuevaimagen = editar.Nuevaimagen;
            string nuevomensaje = editar.Mensajeperfil;
            MemoryStream ms = new MemoryStream();
            nuevaimagen.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            byte[] fotobytes = ms.ToArray();
            string sql = "UPDATE usuarios SET estado=@ESTADO, foto=@FOTO WHERE usuario_twitter = @USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@FOTO", fotobytes);
            comand.Parameters.AddWithValue("@ESTADO", nuevomensaje);
            comand.Parameters.AddWithValue("@USER", Usuario);
            comand.ExecuteNonQuery();
            RescateInfoDinamica(Usuario);//refresco de la info del usuario
        }

        /// <summary>
        /// Evento que responde al logout.
        /// Elimina todos los datos del user y te lleva al inicio.
        /// </summary>
        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Main;
            Usuario = "";
            Contrasenya = "";
            //ESTO NO SE SI ES DEL TODO NECESARIO. TODO
            flowLayoutPanelLastTuits.Controls.Clear();
            flowLayoutPanelTwits.Controls.Clear();
        }

        /// <summary>
        /// Hace hover en el texto de logout.
        /// </summary>
        /// <see cref="LabelLogout_MouseLeave"/>
        private void Label12_MouseEnter(object sender, EventArgs e)
        {
            labelLogout.ForeColor = Color.DarkGray;
        }

        /// <summary>
        /// Hace hover en el texto de logout.
        /// </summary>
        ///<see cref="Label12_MouseEnter"/>
        private void LabelLogout_MouseLeave(object sender, EventArgs e)
        {
            labelLogout.ForeColor = Color.Black;
        }
        //FIN DE CODIGO DE PERFIL


        //CÓDIGO DE FUNCIONES GENERALES DE LA APP
        /// <summary>
        /// Abre el form para hacer tuit y updatea la BBDD al salir.
        /// </summary>
        private void VentanaTuit(){
            Tuitear tuitventana = new Tuitear();
            tuitventana.ShowDialog();
            if (tuitventana.DialogResult == DialogResult.OK)
            {
                string tuit = tuitventana.Texto;
                string sql = "Insert INTO mensajes VALUES(@USER,@RECEPTOR,@DATE,@MENSAJE,@FAVS,@RETS)";
                MySqlCommand comand = new MySqlCommand(sql, conexion);
                comand.Parameters.AddWithValue("@USER", Usuario);
                comand.Parameters.AddWithValue("@RECEPTOR", "");
                comand.Parameters.AddWithValue("@DATE", DateTime.Now.ToString("yyyy-MM-dd h:mm:ss"));
                comand.Parameters.AddWithValue("@MENSAJE", tuit);
                comand.Parameters.AddWithValue("@FAVS", 0);
                comand.Parameters.AddWithValue("@RETS", 0);
                comand.ExecuteNonQuery();
                RescateTwittsSelfUsuario(Usuario);

            }          
        }

        /// <summary>
        /// Rellena los campos del perfil de usuario con sus estadísiticas de tuiter.
        /// </summary>
        private void CargarEstadisticas(){

            String sql = "SELECT COUNT(mensaje) from mensajes WHERE user_emisor=@USER";
            MySqlCommand  comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            MySqlDataReader reader = comand.ExecuteReader();

            if (reader.Read())
            {
                labelPerfilNumTuits.Text = reader[0].ToString();//numero de tuits

            }
            reader.Close();

            sql = "SELECT COUNT(user_seguido) from seguimiento WHERE user_sigue=@USER";
            comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            reader = comand.ExecuteReader();
            if (reader.Read())
            {
                labellabelPerfilSiguiendo.Text = reader[0].ToString();//siguiendo

            }
            reader.Close();

            sql = "SELECT COUNT(user_sigue) from seguimiento WHERE user_seguido=@USER";
            comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            reader = comand.ExecuteReader();
            if (reader.Read())
            {
                labelPerfilSeguidores.Text = reader[0].ToString();//seguidores

            }
            reader.Close();

            sql = "SELECT SUM(num_favs) from mensajes WHERE user_emisor=@USER";
            comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@USER", Usuario);
            reader = comand.ExecuteReader();
            if (reader.Read())
            {
                labelPerfilMegusta.Text = reader[0].ToString();

            }
            reader.Close();
        }

        /// <summary>
        /// Convierte una imagen a un array de bytes para tratarla como un blob.
        /// </summary>
        /// <param name="ruta">ruta es la ruta de la imagen a convertir.</param>
        /// <returns>
        /// La imagen que en forma de array de bytes.
        /// </returns>
        private byte[] FotoABytes(string ruta)
        {
            FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] fotobytes = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return fotobytes;
        }

        /// <summary>
        /// Sube la foto a la base de datos como blob.
        /// </summary>
        /// <param name="ruta">ruta es la ruta de la imagen a convertir.</param>
        private void SubirFoto(string ruta)
        {
            byte[] foto = FotoABytes(ruta);
            string sql = "UPDATE usuarios SET foto = @foto WHERE usuario_twitter=@USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.Add("@foto", MySqlDbType.MediumBlob, foto.Length).Value = foto;
            comand.Parameters.AddWithValue("@USER", Usuario);
            comand.ExecuteNonQuery();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = tabPagePerfilUser;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            ControlPaginas.SelectedTab = Timeline;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            VentanaTuit();
        }
    }
}

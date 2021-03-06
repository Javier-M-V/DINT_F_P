﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CajaTwitt
{

    /// <summary>
    /// Componente personalizado con el layout y el tratamiento de datos de cada tuit.
    /// Contiene las funciones básicas de comportamiento.
    /// </summary>
    public partial class BoxTwit: UserControl
    {
        public int Foto { get; set; }
        public int Favs { get; set; }
        public int Rets { get; set; }
        public string Mensaje { get; set; }
        public string User { get; set; }
        public Image foto { get; set; }
        public event EventHandler ClicEnFoto;

        public MySqlConnection conexion;

        public BoxTwit(ref MySqlConnection conex)
        {

            InitializeComponent();
            conexion = conex;
  
        }

        /// <summary>
        /// Suma uno a los favs.
        /// Actualiza la BBDD.
        /// </summary>
        private void pictureBoxFav_Click(object sender, EventArgs e)
        {
            int favs = Int32.Parse(this.labelFavs.Text);
            favs += 1;
            this.labelFavs.Text = favs.ToString();       
            string sql = "UPDATE mensajes SET num_favs=@FAVS where mensaje = @MENSAJE AND user_emisor = @USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@MENSAJE", Mensaje);
            comand.Parameters.AddWithValue("@FAVS", favs);
            comand.Parameters.AddWithValue("@USER", User);
            comand.ExecuteNonQuery();
        }

        /// <summary>
        /// Suma uno a los rets.
        /// Actualiza la BBDD.
        /// </summary>
        private void pictureBoxRet_Click(object sender, EventArgs e)
        {
            int rets = Int32.Parse(this.labelRets.Text);
            rets += 1;
            this.labelRets.Text = rets.ToString();
            string sql = "UPDATE mensajes SET num_rets=@RETS where mensaje = @MENSAJE AND user_emisor = @USER";
            MySqlCommand comand = new MySqlCommand(sql, conexion);
            comand.Parameters.AddWithValue("@MENSAJE", Mensaje);
            comand.Parameters.AddWithValue("@RETS", rets);
            comand.Parameters.AddWithValue("@USER", User);
            comand.ExecuteNonQuery();
        }

        /// <summary>
        /// Setter de tuits para modificar desde fuera.
        /// </summary>
        public void SetTuit(string Mensaje) {

            this.Mensaje = Mensaje;
            richTextBoxCajaTuit.Text = Mensaje;
        }

        /// <summary>
        /// Setter de nombre de usar para modificar desde fuera.
        /// </summary>
        public void SetUser(string User)
        {
            this.User = User;
            labelUser.Text = User;

        }

        /// <summary>
        /// Setter de favs para modificar desde fuera.
        /// </summary>
        public void SetFavs(int Favs) {

            this.Favs = Favs;
            labelFavs.Text = Favs.ToString();
        }

        /// <summary>
        /// Setter de rets para modificar desde fuera.
        /// </summary>
        public void SetRets (int Rets)
        {
            this.Rets = Rets;
            labelRets.Text = Rets.ToString();
        }

        /// <summary>
        /// Setter de foto para modificar desde fuera.
        /// </summary>
        public void SetFoto(Image foto)
        {
            this.foto = foto;
            pictureBoxFotoPerfil.Image = foto;
            pictureBoxFotoPerfil.Tag = this.User;
        }

        private void pictureBoxFotoPerfil_Click(object sender, EventArgs e)
        {
            if (ClicEnFoto != null)
                ClicEnFoto(sender, e);
        }
   
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DINT_F_P{

    /// <summary>
    /// Formulario de edición del perfil de usuario.
    /// Contiene las funciones básicas de comportamiento.
    /// </summary>
    public partial class FormEditar : Form {

        public string Mensajeperfil { get; set; }
        public Image Nuevaimagen { get; set; }
        public Image imagenvieja;

        public FormEditar(Image imagenvieja){

            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Nuevaimagen = null;
            this.imagenvieja = imagenvieja;
            pictureBoxNuevaFoto.Image = imagenvieja;
        }

        /// <summary>
        /// Responde al Ok del usuario y cierra el form.
        /// Setea el dialog result, la imagen nueva y el estado si son válidos.
        /// </summary>
        private void OK_Click(object sender, EventArgs e) {

            if (textBoxNuevoMensajePerfil.Text == "" ) {

                MessageBox.Show("El mensaje no puede estar vacío");
                DialogResult = DialogResult.Abort;
            }
            else if (pictureBoxNuevaFoto.Image == null) {

                DialogResult = DialogResult.Abort;
            }

            else {

                Nuevaimagen = pictureBoxNuevaFoto.Image;
                Mensajeperfil = textBoxNuevoMensajePerfil.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }           
        }

        /// <summary>
        /// Responde al cancel del usuario, setea al dialogresult y cierra el form.
        /// </summary>
        private void cancel_Click(object sender, EventArgs e){

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Abre un FileDialog y carga la nueva imagen desde local.
        /// </summary>
        private void EditarFoto_Click(object sender, EventArgs e){

            OpenFileDialog dialog = new OpenFileDialog();
            try
            {
                dialog.Title = "Carga una imagen";
                dialog.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    String ruta = dialog.FileName;

                    Image a = new Bitmap(ruta);
                    Nuevaimagen = a;
                    pictureBoxNuevaFoto.Image = a;
                }
            }
            catch (Exception) {
                MessageBox.Show("Algo en la foto se ha roto");
            }
           
        }
        /// <summary>
        /// Responmde al clic en la caja dejando el texto vacío.
        /// </summary>
        private void textBoxNuevoMensajePerfil_Click(object sender, EventArgs e) {

            textBoxNuevoMensajePerfil.Text = "";
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DINT_F_P{

    public partial class FormEditar : Form {

        public string Mensajeperfil { get; set; }
        public Image Nuevaimagen { get; set; }

        public FormEditar(){

            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void OK_Click(object sender, EventArgs e) {

            if (textBoxNuevoMensajePerfil.Text == ""){

                MessageBox.Show("No hay nada en la caja de tu mensaje");
            }
            else {
                Nuevaimagen = pictureBoxNuevaFoto.Image;
                Mensajeperfil = textBoxNuevoMensajePerfil.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }           
        }

        private void cancel_Click(object sender, EventArgs e){

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditarFoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Carga una imagen";
            dialog.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (dialog.ShowDialog() == DialogResult.OK){
                String ruta = dialog.FileName;

                Image a = new Bitmap(ruta);
                Nuevaimagen = a;
                pictureBoxNuevaFoto.Image = a;
            }
        }
        private void textBoxNuevoMensajePerfil_Click(object sender, EventArgs e)
        {
            textBoxNuevoMensajePerfil.Text = "";
        }
    }
}

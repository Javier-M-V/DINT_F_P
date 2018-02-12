using System;
using System.Windows.Forms;

namespace DINT_F_P
{

    /// <summary>
    /// Formulario para tuitear.
    /// Contiene las funciones básicas de scomportamiento.
    /// </summary>
    public partial class Tuitear : Form
    {
        public string Texto { get; set; }
        public Tuitear()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// Responde al botón y setea el nuevo mensaje y el dialogresult si no está vacío.
        /// </summary>
        private void ButtonTwittItForm_Click(object sender, EventArgs e)
        {
            if (PopTuitcaja.Text == "")
            {
                MessageBox.Show("No has escrito twitt");
                
            }
            else {
                Texto = PopTuitcaja.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}

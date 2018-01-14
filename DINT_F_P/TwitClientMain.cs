using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_F_P
{
    public partial class TwitClientMain : Form
    {

        private string usuario { get; set; }
        private string contrasenya { get; set; }

        public TwitClientMain()
        {
            InitializeComponent();
            
        }

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
            //button for twitt

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

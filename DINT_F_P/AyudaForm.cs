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
    public partial class AyudaForm : Form
    {
        public AyudaForm()
        {
            InitializeComponent();
        }

        private void pictureBoxHome_MouseEnter(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "Va a la pantalla principal";
        }

        private void pictureBoxHome_MouseLeave(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "";
        }

        private void pictureBoxLastTwits_MouseEnter(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "Salta la pantalla para tuitar";
        }

        private void pictureBoxLastTwits_MouseLeave(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "";
        }

        private void pictureBoxNotifications_MouseEnter(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "Va a la pantalla de notificaciones";
        }

        private void pictureBoxNotifications_MouseLeave(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "";
        }

        private void pictureBoxConfig_MouseEnter(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "Va a la pantalla de perfil y configuración";
        }

        private void pictureBoxConfig_MouseLeave(object sender, EventArgs e)
        {
            richTextBoxAyuda.Text = "";
        }
    }
}

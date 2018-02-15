using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaNot
{
    public partial class CajaNotificaciones : UserControl
    {

        public Image foto { get; set; }
        public string mensaje { get; set; }
        public CajaNotificaciones()
        {
            InitializeComponent();
        }

        public void SetFoto(Image imagen){

            foto = imagen;
            pictureBoxNotificacionesFoto.Image = foto;

        }
        public void SetMensaje(string sms)
        {

            mensaje = sms;

            richTextBoxNotificacion.Text = mensaje;

        }
    }
}

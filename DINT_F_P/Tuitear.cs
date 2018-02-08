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
    

    public partial class Tuitear : Form
    {
        public string Texto { get; set; }
        public Tuitear()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

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

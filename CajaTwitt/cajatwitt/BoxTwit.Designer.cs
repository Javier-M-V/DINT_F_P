namespace CajaTwitt
{
    partial class BoxTwit
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxTwit));
            this.pictureBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.richTextBoxCajaTuit = new System.Windows.Forms.RichTextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelFavs = new System.Windows.Forms.Label();
            this.labelRets = new System.Windows.Forms.Label();
            this.pictureBoxRet = new System.Windows.Forms.PictureBox();
            this.pictureBoxFav = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFotoPerfil
            // 
            this.pictureBoxFotoPerfil.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            this.pictureBoxFotoPerfil.Size = new System.Drawing.Size(100, 95);
            this.pictureBoxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoPerfil.TabIndex = 0;
            this.pictureBoxFotoPerfil.TabStop = false;
            this.pictureBoxFotoPerfil.Click += new System.EventHandler(this.pictureBoxFotoPerfil_Click);
            // 
            // richTextBoxCajaTuit
            // 
            this.richTextBoxCajaTuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCajaTuit.Enabled = false;
            this.richTextBoxCajaTuit.Location = new System.Drawing.Point(119, 28);
            this.richTextBoxCajaTuit.Name = "richTextBoxCajaTuit";
            this.richTextBoxCajaTuit.Size = new System.Drawing.Size(410, 70);
            this.richTextBoxCajaTuit.TabIndex = 1;
            this.richTextBoxCajaTuit.Text = "";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(120, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(51, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "labelUser";
            // 
            // labelFavs
            // 
            this.labelFavs.AutoSize = true;
            this.labelFavs.Location = new System.Drawing.Point(333, 101);
            this.labelFavs.Name = "labelFavs";
            this.labelFavs.Size = new System.Drawing.Size(35, 13);
            this.labelFavs.TabIndex = 3;
            this.labelFavs.Text = "label2";
            // 
            // labelRets
            // 
            this.labelRets.AutoSize = true;
            this.labelRets.Location = new System.Drawing.Point(422, 101);
            this.labelRets.Name = "labelRets";
            this.labelRets.Size = new System.Drawing.Size(35, 13);
            this.labelRets.TabIndex = 4;
            this.labelRets.Text = "label3";
            // 
            // pictureBoxRet
            // 
            this.pictureBoxRet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRet.Image")));
            this.pictureBoxRet.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRet.InitialImage")));
            this.pictureBoxRet.Location = new System.Drawing.Point(305, 98);
            this.pictureBoxRet.Name = "pictureBoxRet";
            this.pictureBoxRet.Size = new System.Drawing.Size(22, 20);
            this.pictureBoxRet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRet.TabIndex = 5;
            this.pictureBoxRet.TabStop = false;
            this.pictureBoxRet.Click += new System.EventHandler(this.pictureBoxFav_Click);
            // 
            // pictureBoxFav
            // 
            this.pictureBoxFav.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFav.Image")));
            this.pictureBoxFav.Location = new System.Drawing.Point(394, 98);
            this.pictureBoxFav.Name = "pictureBoxFav";
            this.pictureBoxFav.Size = new System.Drawing.Size(22, 20);
            this.pictureBoxFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFav.TabIndex = 6;
            this.pictureBoxFav.TabStop = false;
            this.pictureBoxFav.Click += new System.EventHandler(this.pictureBoxRet_Click);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.pictureBoxFav);
            this.Controls.Add(this.pictureBoxRet);
            this.Controls.Add(this.labelRets);
            this.Controls.Add(this.labelFavs);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.richTextBoxCajaTuit);
            this.Controls.Add(this.pictureBoxFotoPerfil);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(534, 121);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFotoPerfil;
        private System.Windows.Forms.RichTextBox richTextBoxCajaTuit;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelFavs;
        private System.Windows.Forms.Label labelRets;
        private System.Windows.Forms.PictureBox pictureBoxRet;
        private System.Windows.Forms.PictureBox pictureBoxFav;
    }
}

namespace DINT_F_P
{
    partial class AyudaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyudaForm));
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBoxConfig = new System.Windows.Forms.PictureBox();
            this.pictureBoxNotifications = new System.Windows.Forms.PictureBox();
            this.pictureBoxLastTwits = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.richTextBoxAyuda = new System.Windows.Forms.RichTextBox();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastTwits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.pictureBoxConfig);
            this.panel8.Controls.Add(this.pictureBoxNotifications);
            this.panel8.Controls.Add(this.pictureBoxLastTwits);
            this.panel8.Controls.Add(this.pictureBoxHome);
            this.panel8.Location = new System.Drawing.Point(49, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 31);
            this.panel8.TabIndex = 6;
            // 
            // pictureBoxConfig
            // 
            this.pictureBoxConfig.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConfig.Image")));
            this.pictureBoxConfig.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxConfig.InitialImage")));
            this.pictureBoxConfig.Location = new System.Drawing.Point(182, 0);
            this.pictureBoxConfig.Name = "pictureBoxConfig";
            this.pictureBoxConfig.Size = new System.Drawing.Size(25, 21);
            this.pictureBoxConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfig.TabIndex = 7;
            this.pictureBoxConfig.TabStop = false;
            this.pictureBoxConfig.MouseEnter += new System.EventHandler(this.pictureBoxConfig_MouseEnter);
            this.pictureBoxConfig.MouseLeave += new System.EventHandler(this.pictureBoxConfig_MouseLeave);
            // 
            // pictureBoxNotifications
            // 
            this.pictureBoxNotifications.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNotifications.Image")));
            this.pictureBoxNotifications.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNotifications.InitialImage")));
            this.pictureBoxNotifications.Location = new System.Drawing.Point(151, 0);
            this.pictureBoxNotifications.Name = "pictureBoxNotifications";
            this.pictureBoxNotifications.Size = new System.Drawing.Size(25, 21);
            this.pictureBoxNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNotifications.TabIndex = 6;
            this.pictureBoxNotifications.TabStop = false;
            this.pictureBoxNotifications.MouseEnter += new System.EventHandler(this.pictureBoxNotifications_MouseEnter);
            this.pictureBoxNotifications.MouseLeave += new System.EventHandler(this.pictureBoxNotifications_MouseLeave);
            // 
            // pictureBoxLastTwits
            // 
            this.pictureBoxLastTwits.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLastTwits.Image")));
            this.pictureBoxLastTwits.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLastTwits.InitialImage")));
            this.pictureBoxLastTwits.Location = new System.Drawing.Point(120, 0);
            this.pictureBoxLastTwits.Name = "pictureBoxLastTwits";
            this.pictureBoxLastTwits.Size = new System.Drawing.Size(25, 21);
            this.pictureBoxLastTwits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLastTwits.TabIndex = 4;
            this.pictureBoxLastTwits.TabStop = false;
            this.pictureBoxLastTwits.MouseEnter += new System.EventHandler(this.pictureBoxLastTwits_MouseEnter);
            this.pictureBoxLastTwits.MouseLeave += new System.EventHandler(this.pictureBoxLastTwits_MouseLeave);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.InitialImage")));
            this.pictureBoxHome.Location = new System.Drawing.Point(89, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(25, 21);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 3;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.MouseEnter += new System.EventHandler(this.pictureBoxHome_MouseEnter);
            this.pictureBoxHome.MouseLeave += new System.EventHandler(this.pictureBoxHome_MouseLeave);
            // 
            // richTextBoxAyuda
            // 
            this.richTextBoxAyuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAyuda.Enabled = false;
            this.richTextBoxAyuda.Location = new System.Drawing.Point(49, 50);
            this.richTextBoxAyuda.Name = "richTextBoxAyuda";
            this.richTextBoxAyuda.Size = new System.Drawing.Size(293, 96);
            this.richTextBoxAyuda.TabIndex = 7;
            this.richTextBoxAyuda.Text = "";
            // 
            // AyudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 167);
            this.Controls.Add(this.richTextBoxAyuda);
            this.Controls.Add(this.panel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AyudaForm";
            this.Text = "AyudaForm";
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastTwits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBoxConfig;
        private System.Windows.Forms.PictureBox pictureBoxNotifications;
        private System.Windows.Forms.PictureBox pictureBoxLastTwits;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.RichTextBox richTextBoxAyuda;
    }
}
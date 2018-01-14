namespace DINT_F_P
{
    partial class TwitClientMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlPaginas = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.UserMainTimeline = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxCajaTwit = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Profiles = new System.Windows.Forms.TabPage();
            this.LastNotifications = new System.Windows.Forms.TabPage();
            this.ControlPaginas.SuspendLayout();
            this.Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserMainTimeline.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPaginas
            // 
            this.ControlPaginas.Controls.Add(this.Main);
            this.ControlPaginas.Controls.Add(this.UserMainTimeline);
            this.ControlPaginas.Controls.Add(this.Profiles);
            this.ControlPaginas.Controls.Add(this.LastNotifications);
            this.ControlPaginas.Location = new System.Drawing.Point(2, 5);
            this.ControlPaginas.Name = "ControlPaginas";
            this.ControlPaginas.SelectedIndex = 0;
            this.ControlPaginas.Size = new System.Drawing.Size(1005, 549);
            this.ControlPaginas.TabIndex = 1;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.panel1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(997, 523);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(338, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start to use TwitClient!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxContrasenya);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Location = new System.Drawing.Point(322, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 112);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(146, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(86, 40);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(195, 20);
            this.textBoxContrasenya.TabIndex = 2;
            this.textBoxContrasenya.Text = "*****";
            this.textBoxContrasenya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(86, 14);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(195, 20);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.Text = "@twitterUser";
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserMainTimeline
            // 
            this.UserMainTimeline.Controls.Add(this.panel2);
            this.UserMainTimeline.Controls.Add(this.richTextBoxCajaTwit);
            this.UserMainTimeline.Controls.Add(this.label2);
            this.UserMainTimeline.Location = new System.Drawing.Point(4, 22);
            this.UserMainTimeline.Name = "UserMainTimeline";
            this.UserMainTimeline.Padding = new System.Windows.Forms.Padding(3);
            this.UserMainTimeline.Size = new System.Drawing.Size(997, 523);
            this.UserMainTimeline.TabIndex = 1;
            this.UserMainTimeline.Text = "Timeline";
            this.UserMainTimeline.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(284, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 324);
            this.panel2.TabIndex = 3;
            // 
            // richTextBoxCajaTwit
            // 
            this.richTextBoxCajaTwit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCajaTwit.Location = new System.Drawing.Point(19, 61);
            this.richTextBoxCajaTwit.Name = "richTextBoxCajaTwit";
            this.richTextBoxCajaTwit.Size = new System.Drawing.Size(242, 63);
            this.richTextBoxCajaTwit.TabIndex = 2;
            this.richTextBoxCajaTwit.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timeline";
            // 
            // Profiles
            // 
            this.Profiles.Location = new System.Drawing.Point(4, 22);
            this.Profiles.Name = "Profiles";
            this.Profiles.Size = new System.Drawing.Size(997, 523);
            this.Profiles.TabIndex = 2;
            this.Profiles.Text = "Profiles";
            this.Profiles.UseVisualStyleBackColor = true;
            // 
            // LastNotifications
            // 
            this.LastNotifications.Location = new System.Drawing.Point(4, 22);
            this.LastNotifications.Name = "LastNotifications";
            this.LastNotifications.Size = new System.Drawing.Size(997, 523);
            this.LastNotifications.TabIndex = 4;
            this.LastNotifications.Text = "LastNotifications";
            this.LastNotifications.UseVisualStyleBackColor = true;
            // 
            // TwitClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 557);
            this.Controls.Add(this.ControlPaginas);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "TwitClientMain";
            this.Text = "TwitClient";
            this.ControlPaginas.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserMainTimeline.ResumeLayout(false);
            this.UserMainTimeline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ControlPaginas;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage UserMainTimeline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxCajaTwit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Profiles;
        private System.Windows.Forms.TabPage LastNotifications;
    }
}


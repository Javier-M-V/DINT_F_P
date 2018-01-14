using DINT_F_P.Properties;

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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.UserMainTimeline = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxCajaTwit = new System.Windows.Forms.RichTextBox();
            this.LastTwits = new System.Windows.Forms.TabPage();
            this.LastNotifications = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ControlPaginas.SuspendLayout();
            this.Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserMainTimeline.SuspendLayout();
            this.LastTwits.SuspendLayout();
            this.LastNotifications.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPaginas
            // 
            this.ControlPaginas.Controls.Add(this.Main);
            this.ControlPaginas.Controls.Add(this.UserMainTimeline);
            this.ControlPaginas.Controls.Add(this.LastTwits);
            this.ControlPaginas.Controls.Add(this.LastNotifications);
            this.ControlPaginas.Location = new System.Drawing.Point(-2, 12);
            this.ControlPaginas.Name = "ControlPaginas";
            this.ControlPaginas.SelectedIndex = 0;
            this.ControlPaginas.Size = new System.Drawing.Size(1009, 542);
            this.ControlPaginas.TabIndex = 1;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.panel1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(1001, 516);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(354, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start to use TwitClient!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxContrasenya);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Location = new System.Drawing.Point(338, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 103);
            this.panel1.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogin.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonLogin.Location = new System.Drawing.Point(146, 66);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click_1);
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
            this.UserMainTimeline.Controls.Add(this.panel3);
            this.UserMainTimeline.Location = new System.Drawing.Point(4, 22);
            this.UserMainTimeline.Name = "UserMainTimeline";
            this.UserMainTimeline.Padding = new System.Windows.Forms.Padding(3);
            this.UserMainTimeline.Size = new System.Drawing.Size(1001, 516);
            this.UserMainTimeline.TabIndex = 1;
            this.UserMainTimeline.Text = "Timeline";
            this.UserMainTimeline.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(230, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 240);
            this.panel2.TabIndex = 3;
            // 
            // richTextBoxCajaTwit
            // 
            this.richTextBoxCajaTwit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCajaTwit.Location = new System.Drawing.Point(230, 98);
            this.richTextBoxCajaTwit.Name = "richTextBoxCajaTwit";
            this.richTextBoxCajaTwit.Size = new System.Drawing.Size(291, 63);
            this.richTextBoxCajaTwit.TabIndex = 2;
            this.richTextBoxCajaTwit.Text = "";
            // 
            // LastTwits
            // 
            this.LastTwits.Controls.Add(this.panel4);
            this.LastTwits.Location = new System.Drawing.Point(4, 22);
            this.LastTwits.Name = "LastTwits";
            this.LastTwits.Size = new System.Drawing.Size(1001, 516);
            this.LastTwits.TabIndex = 2;
            this.LastTwits.Text = "LastTwits";
            this.LastTwits.UseVisualStyleBackColor = true;
            // 
            // LastNotifications
            // 
            this.LastNotifications.Controls.Add(this.panel6);
            this.LastNotifications.Location = new System.Drawing.Point(4, 22);
            this.LastNotifications.Name = "LastNotifications";
            this.LastNotifications.Size = new System.Drawing.Size(1001, 516);
            this.LastNotifications.TabIndex = 4;
            this.LastNotifications.Text = "LastNotifications";
            this.LastNotifications.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timeline";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.richTextBoxCajaTwit);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 514);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(989, 514);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(230, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(541, 240);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Your last twits";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(230, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 63);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.richTextBox2);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(989, 514);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(230, 167);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(541, 240);
            this.panel7.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(20, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Your last notifications";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(230, 98);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(291, 63);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
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
            this.LastTwits.ResumeLayout(false);
            this.LastNotifications.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ControlPaginas;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage UserMainTimeline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxCajaTwit;
        private System.Windows.Forms.TabPage LastTwits;
        private System.Windows.Forms.TabPage LastNotifications;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}


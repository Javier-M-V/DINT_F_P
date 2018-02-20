namespace DINT_F_P
{
    partial class Tuitear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tuitear));
            this.ButtonTwittItForm = new BotonCustom.CustomButton1();
            this.PopTuitcaja = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonTwittItForm
            // 
            this.ButtonTwittItForm.BackColor = System.Drawing.Color.Black;
            this.ButtonTwittItForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonTwittItForm.ForeColor = System.Drawing.Color.White;
            this.ButtonTwittItForm.Location = new System.Drawing.Point(309, 52);
            this.ButtonTwittItForm.Name = "ButtonTwittItForm";
            this.ButtonTwittItForm.Size = new System.Drawing.Size(66, 23);
            this.ButtonTwittItForm.TabIndex = 8;
            this.ButtonTwittItForm.Text = "Twitt It!";
            this.ButtonTwittItForm.UseVisualStyleBackColor = false;
            this.ButtonTwittItForm.Click += new System.EventHandler(this.ButtonTwittItForm_Click);
            // 
            // PopTuitcaja
            // 
            this.PopTuitcaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopTuitcaja.Location = new System.Drawing.Point(12, 12);
            this.PopTuitcaja.MaxLength = 250;
            this.PopTuitcaja.Name = "PopTuitcaja";
            this.PopTuitcaja.Size = new System.Drawing.Size(291, 63);
            this.PopTuitcaja.TabIndex = 7;
            this.PopTuitcaja.Text = "";
            this.PopTuitcaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PopTuitcaja_KeyDown);
            // 
            // Tuitear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 98);
            this.Controls.Add(this.ButtonTwittItForm);
            this.Controls.Add(this.PopTuitcaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tuitear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tuitear";
            this.ResumeLayout(false);

        }

        #endregion

        private BotonCustom.CustomButton1 ButtonTwittItForm;
        private System.Windows.Forms.RichTextBox PopTuitcaja;
    }
}
namespace CajaNot
{
    partial class CajaNotificaciones
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
            this.richTextBoxNotificacion = new System.Windows.Forms.RichTextBox();
            this.pictureBoxNotificacionesFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotificacionesFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxNotificacion
            // 
            this.richTextBoxNotificacion.Location = new System.Drawing.Point(152, 3);
            this.richTextBoxNotificacion.Name = "richTextBoxNotificacion";
            this.richTextBoxNotificacion.ReadOnly = true;
            this.richTextBoxNotificacion.Size = new System.Drawing.Size(280, 57);
            this.richTextBoxNotificacion.TabIndex = 0;
            this.richTextBoxNotificacion.Text = "";
            // 
            // pictureBoxNotificacionesFoto
            // 
            this.pictureBoxNotificacionesFoto.Location = new System.Drawing.Point(64, 3);
            this.pictureBoxNotificacionesFoto.Name = "pictureBoxNotificacionesFoto";
            this.pictureBoxNotificacionesFoto.Size = new System.Drawing.Size(63, 57);
            this.pictureBoxNotificacionesFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNotificacionesFoto.TabIndex = 1;
            this.pictureBoxNotificacionesFoto.TabStop = false;
            // 
            // CajaNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxNotificacionesFoto);
            this.Controls.Add(this.richTextBoxNotificacion);
            this.Name = "CajaNotificaciones";
            this.Size = new System.Drawing.Size(568, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotificacionesFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxNotificacion;
        private System.Windows.Forms.PictureBox pictureBoxNotificacionesFoto;
    }
}

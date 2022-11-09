namespace PPAI.Interfaz
{
    partial class Notificacion
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
            this.grupoNotificacion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxWhatsapp = new System.Windows.Forms.CheckBox();
            this.checkBoxMail = new System.Windows.Forms.CheckBox();
            this.textRT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listInformacion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupoNotificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoNotificacion
            // 
            this.grupoNotificacion.BackColor = System.Drawing.SystemColors.Control;
            this.grupoNotificacion.Controls.Add(this.btnCancelar);
            this.grupoNotificacion.Controls.Add(this.btnEnviar);
            this.grupoNotificacion.Controls.Add(this.label3);
            this.grupoNotificacion.Controls.Add(this.checkBoxWhatsapp);
            this.grupoNotificacion.Controls.Add(this.checkBoxMail);
            this.grupoNotificacion.Controls.Add(this.textRT);
            this.grupoNotificacion.Controls.Add(this.label2);
            this.grupoNotificacion.Controls.Add(this.listInformacion);
            this.grupoNotificacion.Controls.Add(this.label1);
            this.grupoNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoNotificacion.Location = new System.Drawing.Point(12, 12);
            this.grupoNotificacion.Name = "grupoNotificacion";
            this.grupoNotificacion.Size = new System.Drawing.Size(661, 495);
            this.grupoNotificacion.TabIndex = 10;
            this.grupoNotificacion.TabStop = false;
            this.grupoNotificacion.Text = "Informacion ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(373, 438);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 39);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(520, 438);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 39);
            this.btnEnviar.TabIndex = 23;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enviar notificación vía:";
            // 
            // checkBoxWhatsapp
            // 
            this.checkBoxWhatsapp.AutoSize = true;
            this.checkBoxWhatsapp.Location = new System.Drawing.Point(12, 413);
            this.checkBoxWhatsapp.Name = "checkBoxWhatsapp";
            this.checkBoxWhatsapp.Size = new System.Drawing.Size(132, 29);
            this.checkBoxWhatsapp.TabIndex = 6;
            this.checkBoxWhatsapp.Text = "WhatsApp";
            this.checkBoxWhatsapp.UseVisualStyleBackColor = true;
            // 
            // checkBoxMail
            // 
            this.checkBoxMail.AutoSize = true;
            this.checkBoxMail.Checked = true;
            this.checkBoxMail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMail.Location = new System.Drawing.Point(12, 378);
            this.checkBoxMail.Name = "checkBoxMail";
            this.checkBoxMail.Size = new System.Drawing.Size(71, 29);
            this.checkBoxMail.TabIndex = 5;
            this.checkBoxMail.Text = "Mail";
            this.checkBoxMail.UseVisualStyleBackColor = true;
            // 
            // textRT
            // 
            this.textRT.Enabled = false;
            this.textRT.Location = new System.Drawing.Point(233, 91);
            this.textRT.Name = "textRT";
            this.textRT.Size = new System.Drawing.Size(407, 30);
            this.textRT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recurso tecnológico:";
            // 
            // listInformacion
            // 
            this.listInformacion.FormattingEnabled = true;
            this.listInformacion.ItemHeight = 25;
            this.listInformacion.Location = new System.Drawing.Point(12, 132);
            this.listInformacion.Name = "listInformacion";
            this.listInformacion.Size = new System.Drawing.Size(628, 179);
            this.listInformacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información RT en Mantenimiento Correctivo";
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 519);
            this.Controls.Add(this.grupoNotificacion);
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacion";
            this.Load += new System.EventHandler(this.Notificacion_Load);
            this.grupoNotificacion.ResumeLayout(false);
            this.grupoNotificacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoNotificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listInformacion;
        private System.Windows.Forms.TextBox textRT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxWhatsapp;
        private System.Windows.Forms.CheckBox checkBoxMail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
namespace PPAI.Interfaz
{
    partial class TurnosRT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnosRT));
            this.grupoTurnos = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cientifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaTurnos = new System.Windows.Forms.DataGridView();
            this.grupoTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoTurnos
            // 
            this.grupoTurnos.BackColor = System.Drawing.SystemColors.Control;
            this.grupoTurnos.Controls.Add(this.btnConfirmar);
            this.grupoTurnos.Controls.Add(this.grillaTurnos);
            this.grupoTurnos.Controls.Add(this.label4);
            this.grupoTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoTurnos.Location = new System.Drawing.Point(12, 12);
            this.grupoTurnos.Name = "grupoTurnos";
            this.grupoTurnos.Size = new System.Drawing.Size(910, 340);
            this.grupoTurnos.TabIndex = 23;
            this.grupoTurnos.TabStop = false;
            this.grupoTurnos.Text = "Turnos";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(784, 301);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 32);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Turnos RT";
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Mail";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mail.DefaultCellStyle = dataGridViewCellStyle6;
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.Width = 250;
            // 
            // Cientifico
            // 
            this.Cientifico.DataPropertyName = "Cientifico";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cientifico.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cientifico.HeaderText = "Cientifico";
            this.Cientifico.Name = "Cientifico";
            this.Cientifico.Width = 130;
            // 
            // Fin
            // 
            this.Fin.DataPropertyName = "Fin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fin.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fin.HeaderText = "Fin";
            this.Fin.Name = "Fin";
            this.Fin.Width = 220;
            // 
            // Inicio
            // 
            this.Inicio.DataPropertyName = "Inicio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Inicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.Width = 220;
            // 
            // grillaTurnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.grillaTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaTurnos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaTurnos.ColumnHeadersHeight = 33;
            this.grillaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillaTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inicio,
            this.Fin,
            this.Cientifico,
            this.Mail});
            this.grillaTurnos.Location = new System.Drawing.Point(12, 82);
            this.grillaTurnos.Name = "grillaTurnos";
            this.grillaTurnos.RowTemplate.Height = 28;
            this.grillaTurnos.Size = new System.Drawing.Size(892, 213);
            this.grillaTurnos.TabIndex = 2;
            // 
            // TurnosRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 364);
            this.Controls.Add(this.grupoTurnos);
            this.Name = "TurnosRT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurnosRT";
            this.grupoTurnos.ResumeLayout(false);
            this.grupoTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoTurnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView grillaTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cientifico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    }
}
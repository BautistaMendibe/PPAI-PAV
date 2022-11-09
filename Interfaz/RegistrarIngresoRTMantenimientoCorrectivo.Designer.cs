namespace PPAI.Interfaz
{
    partial class RegistrarIngresoRTMantenimientoCorrectivo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarIngresoRTMantenimientoCorrectivo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grillaRTDisponibles = new System.Windows.Forms.DataGridView();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaFinPrevista = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxFin = new System.Windows.Forms.GroupBox();
            this.btnFechaRazon = new System.Windows.Forms.Button();
            this.btnEnviarMail = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRTDisponibles)).BeginInit();
            this.groupBoxFin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.grillaRTDisponibles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 291);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos Tecnológicos";
            // 
            // grillaRTDisponibles
            // 
            this.grillaRTDisponibles.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaRTDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaRTDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRTDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaAlta,
            this.Num,
            this.Tipo,
            this.Marc,
            this.Modelo,
            this.Imagenes,
            this.Periodicidad,
            this.Fraccion,
            this.Duracion});
            this.grillaRTDisponibles.Location = new System.Drawing.Point(12, 82);
            this.grillaRTDisponibles.Name = "grillaRTDisponibles";
            this.grillaRTDisponibles.RowTemplate.Height = 26;
            this.grillaRTDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaRTDisponibles.Size = new System.Drawing.Size(620, 203);
            this.grillaRTDisponibles.TabIndex = 2;
            this.grillaRTDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaRTDisponibles_CellContentClick);
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "FechaAlta";
            this.FechaAlta.HeaderText = "FechaAlta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.Visible = false;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Numero";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Num.DefaultCellStyle = dataGridViewCellStyle2;
            this.Num.HeaderText = "Numero";
            this.Num.Name = "Num";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 150;
            // 
            // Marc
            // 
            this.Marc.DataPropertyName = "Marca";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Marc.DefaultCellStyle = dataGridViewCellStyle4;
            this.Marc.HeaderText = "Marca";
            this.Marc.Name = "Marc";
            this.Marc.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle5;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 150;
            // 
            // Imagenes
            // 
            this.Imagenes.DataPropertyName = "Imagenes";
            this.Imagenes.HeaderText = "Imagenes";
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.Visible = false;
            // 
            // Periodicidad
            // 
            this.Periodicidad.DataPropertyName = "Periodicidad";
            this.Periodicidad.HeaderText = "Periodicidad";
            this.Periodicidad.Name = "Periodicidad";
            this.Periodicidad.Visible = false;
            // 
            // Fraccion
            // 
            this.Fraccion.DataPropertyName = "FraccionHorarioTurno";
            this.Fraccion.HeaderText = "Fraccion";
            this.Fraccion.Name = "Fraccion";
            this.Fraccion.Visible = false;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "Duracion";
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recursos disponibles:";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(225, 64);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(407, 30);
            this.txtRazon.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Razón de mantenimiento";
            // 
            // txtFechaFinPrevista
            // 
            this.txtFechaFinPrevista.Location = new System.Drawing.Point(168, 19);
            this.txtFechaFinPrevista.Mask = "00/00/0000";
            this.txtFechaFinPrevista.Name = "txtFechaFinPrevista";
            this.txtFechaFinPrevista.Size = new System.Drawing.Size(120, 30);
            this.txtFechaFinPrevista.TabIndex = 18;
            this.txtFechaFinPrevista.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha fin prevista";
            this.label2.UseMnemonic = false;
            // 
            // groupBoxFin
            // 
            this.groupBoxFin.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxFin.Controls.Add(this.btnFechaRazon);
            this.groupBoxFin.Controls.Add(this.txtRazon);
            this.groupBoxFin.Controls.Add(this.label2);
            this.groupBoxFin.Controls.Add(this.label3);
            this.groupBoxFin.Controls.Add(this.txtFechaFinPrevista);
            this.groupBoxFin.Enabled = false;
            this.groupBoxFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFin.Location = new System.Drawing.Point(12, 309);
            this.groupBoxFin.Name = "groupBoxFin";
            this.groupBoxFin.Size = new System.Drawing.Size(646, 156);
            this.groupBoxFin.TabIndex = 21;
            this.groupBoxFin.TabStop = false;
            // 
            // btnFechaRazon
            // 
            this.btnFechaRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaRazon.Location = new System.Drawing.Point(512, 118);
            this.btnFechaRazon.Name = "btnFechaRazon";
            this.btnFechaRazon.Size = new System.Drawing.Size(120, 32);
            this.btnFechaRazon.TabIndex = 21;
            this.btnFechaRazon.Text = "Ingresar Datos";
            this.btnFechaRazon.UseVisualStyleBackColor = true;
            this.btnFechaRazon.Click += new System.EventHandler(this.btnFechaRazon_Click);
            // 
            // btnEnviarMail
            // 
            this.btnEnviarMail.Enabled = false;
            this.btnEnviarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMail.Location = new System.Drawing.Point(537, 471);
            this.btnEnviarMail.Name = "btnEnviarMail";
            this.btnEnviarMail.Size = new System.Drawing.Size(120, 39);
            this.btnEnviarMail.TabIndex = 22;
            this.btnEnviarMail.Text = "Aceptar mantenimiento";
            this.btnEnviarMail.UseVisualStyleBackColor = true;
            this.btnEnviarMail.Click += new System.EventHandler(this.btnEnviarMail_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(398, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 39);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar mantenimiento";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 471);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 39);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(527, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ver todos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RegistrarIngresoRTMantenimientoCorrectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 522);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviarMail);
            this.Controls.Add(this.groupBoxFin);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarIngresoRTMantenimientoCorrectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso a Mantenimiento Correctivo";
            this.Load += new System.EventHandler(this.RegistrarIngresoRTMantenimientoCorrectivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRTDisponibles)).EndInit();
            this.groupBoxFin.ResumeLayout(false);
            this.groupBoxFin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaRTDisponibles;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFechaFinPrevista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxFin;
        private System.Windows.Forms.Button btnFechaRazon;
        private System.Windows.Forms.Button btnEnviarMail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.Label label4;
    }
}
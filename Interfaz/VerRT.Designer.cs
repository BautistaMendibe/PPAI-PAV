
namespace PPAI.Interfaz
{
    partial class VerRT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerRT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grillaRT = new System.Windows.Forms.DataGridView();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.grillaRT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 373);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos Tecnológicos";
            // 
            // grillaRT
            // 
            this.grillaRT.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaRT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaAlta,
            this.Num,
            this.Tipo,
            this.Marc,
            this.Modelo,
            this.Imagenes,
            this.Periodicidad,
            this.Fraccion,
            this.Duracion,
            this.estado,
            this.responsable});
            this.grillaRT.Location = new System.Drawing.Point(12, 44);
            this.grillaRT.Name = "grillaRT";
            this.grillaRT.RowTemplate.Height = 26;
            this.grillaRT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaRT.Size = new System.Drawing.Size(825, 324);
            this.grillaRT.TabIndex = 2;
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
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.Width = 150;
            // 
            // VerRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerRT";
            this.Text = "Ver Recursos Tecnológicos";
            this.Load += new System.EventHandler(this.VerRT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaRT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
    }
}
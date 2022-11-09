using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Entidades;
using PPAI.Controlador;

namespace PPAI.Interfaz
{
    public partial class Notificacion : Form
    {
        public Notificacion()
        {
            InitializeComponent();
        }

        private void Notificacion_Load(object sender, EventArgs e)
        {

        }

        public void cargarDatos(RecursoTecnologico rt,  List<Turno> turnos)
        {
            string nombreRecurso = " ";
            nombreRecurso = "Número: " + rt.NumeroRT.ToString() + " - Tipo: " + rt.TipoRecurso.Nombre.ToString();
            textRT.Text = nombreRecurso;

            if (turnos != null)
            {
                for (int i = 0; i < turnos.Count; i++)
                {
                    listInformacion.Items.Add("Informacion del turno: " + (i + 1).ToString());
                    listInformacion.Items.Add("Fecha/Hora Inicio: " + turnos[i].FechaHoraInicio.ToString());
                    listInformacion.Items.Add("Fecha/Hora Fin: " + turnos[i].FechaHoraFin.ToString());
                    listInformacion.Items.Add("Cientifico: " + turnos[i].AsignacionCientifico.PC.Nombre.ToString());
                    listInformacion.Items.Add("Mail: " + turnos[i].AsignacionCientifico.PC.CorreoInstitu.ToString());
                }
            }
            else
            {
                listInformacion.Items.Add("No tiene turnos para cancelar");
            }
            


        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (checkBoxMail.Checked)
            {
                if (checkBoxWhatsapp.Checked)
                {
                    MessageBox.Show("Correo y mensaje via WhatsApp enviado con éxito");
                }
                else
                {
                    MessageBox.Show("Correo enviado con éxito");
                }
            }
            else
            {
                MessageBox.Show("Mensaje a WhatsApp enviado con éxito");
            }

            
            this.Close();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

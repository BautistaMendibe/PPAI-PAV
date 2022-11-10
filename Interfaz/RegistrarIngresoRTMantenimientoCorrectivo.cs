using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.AccesoDatos;
using PPAI.Controlador;
using PPAI.Entidades;

namespace PPAI.Interfaz
{
    public partial class RegistrarIngresoRTMantenimientoCorrectivo : Form
    {
        GestorRegistrarIngresoRTMantenimientoCorrectivo gestor;
        string numero;
        List<Turno> turnos;

        public RegistrarIngresoRTMantenimientoCorrectivo()
        {
            InitializeComponent();
        }

        private void RegistrarIngresoRTMantenimientoCorrectivo_Load(object sender, EventArgs e)
        {
            gestor = new GestorRegistrarIngresoRTMantenimientoCorrectivo(this);
            gestor.registrarIngresoRTMantenimientoCorrectivo();

        }

        private void txtBoxRTDisponibles_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void cargarGrillaRTDisponibles(List<RecursoTecnologico> rts)
        {
            DataRow row;
            DataColumn column;
            try
            {
                DataTable tablaRecursos = new DataTable();

                column = new DataColumn();
                column.ColumnName = "Numero";
                tablaRecursos.Columns.Add(column);

                column = new DataColumn();
                column.ColumnName = "Tipo";
                tablaRecursos.Columns.Add(column);

                column = new DataColumn();
                column.ColumnName = "Marca";
                tablaRecursos.Columns.Add(column);

                column = new DataColumn();
                column.ColumnName = "Modelo";
                tablaRecursos.Columns.Add(column);

                foreach (RecursoTecnologico r in rts)
                {
                    row = tablaRecursos.NewRow();
                    row["Numero"] = r.NumeroRT;
                    row["Tipo"] = r.TipoRecurso.Nombre.ToString();
                    row["Modelo"] = r.Modelo.Nombre.ToString();
                    row["Marca"] = r.Modelo.Marca.Nombre.ToString();
                    tablaRecursos.Rows.Add(row);
                }

                grillaRTDisponibles.DataSource = tablaRecursos;
                grillaRTDisponibles.Sort(grillaRTDisponibles.Columns["Tipo"], ListSortDirection.Ascending);

                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay listado de recursos tecnologicos");
            }            
        }

        private void grillaRTDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaRTDisponibles.Rows[indice];
            string numero = filaseleccionada.Cells["Num"].Value.ToString();
            this.numero = numero;
            gestor.rtSeleccionado(numero);
            groupBoxFin.Enabled = true;
            solicitarFechaFinPrevista();
            txtFechaFinPrevista.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        public void solicitarSeleccionRT()
        {
            MessageBox.Show("Por favor seleccionar un recurso tecnologico");
        }

        public void solicitarFechaFinPrevista()
        {
            MessageBox.Show("Ingresar fecha fin prevista y motivo de mantenimiento");
        }

        private void btnFechaRazon_Click(object sender, EventArgs e)
        {
            if (txtFechaFinPrevista.Text.Equals("") || txtRazon.Text.Equals(""))
            {
                MessageBox.Show("Ingresar los datos solicitados.");
            }
            else
            {
                DateTime fechaFin = DateTime.Parse(txtFechaFinPrevista.Text.Trim());
                string motivoMantenimiento = txtRazon.Text;
                gestor.fechaFinPrevista(fechaFin);
                gestor.razonMantenimiento(motivoMantenimiento);
                
            }
            
        }

        public void confirmarMantenimiento()
        {
            gestor.ingresarRTMantenimientoCorrectivo(true);
        }

        public void cargarTurnos(List<Turno> turnos)
        {
            TurnosRT ventanaTurnos = new TurnosRT(this);
            ventanaTurnos.cargarGrillaTurnos(turnos);
            ventanaTurnos.Show();
            //this.turnos = turnos;
            //confirmarMantenimiento();
            //btnEnviarMail.Enabled = true;
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            gestor.generarMail();
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El mantenimiento fue cancelado");
            this.Close();
            Principal menu = new Principal();
            menu.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal menu = new Principal();
            menu.Show();
        }

        public void aviso()
        {
            DialogResult resultado = MessageBox.Show("No existen recursos asociados al responsable técnico en estado posible de ingresar en mantenimiento correctivo", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay recursos asociados");
                this.Close();
            }
        }

        public void aviso2()
        {
            DialogResult resultado = MessageBox.Show("No existen turnos reservados a cancelar.", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                btnEnviarMail.Enabled = true;
                gestor.ingresarRTMantenimientoCorrectivo(false);
            }
            else
            {
                MessageBox.Show("No hay turnos.");
                this.Close();
            }
        }

        public void limpiarCampos()
        {
            txtFechaFinPrevista.Text = "";
            txtRazon.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var verRT = new VerRT();
            verRT.Show();
        }

        public void activarBotonConfirmar()
        {
            btnEnviarMail.Enabled = true;
        }
    }
}

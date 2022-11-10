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

namespace PPAI.Interfaz
{
    public partial class TurnosRT : Form
    {
        private RegistrarIngresoRTMantenimientoCorrectivo pantalla;
        public TurnosRT(RegistrarIngresoRTMantenimientoCorrectivo gestor)
        {
            InitializeComponent();
            pantalla = gestor;
        }

        public void cargarGrillaTurnos(List<Turno> turnos)
        {
            DataRow row;
            DataColumn column;
            try
            {
                grillaTurnos.DataSource = turnos;
                DataTable tablaRecursos = new DataTable();

                column = new DataColumn();
                column.ColumnName = "Inicio";
                tablaRecursos.Columns.Add(column);

                column = new DataColumn();
                column.ColumnName = "Fin";
                tablaRecursos.Columns.Add(column);

                column = new DataColumn();
                column.ColumnName = "Cientifico";
                tablaRecursos.Columns.Add(column);

                column = new DataColumn();
                column.ColumnName = "Mail";
                tablaRecursos.Columns.Add(column);

                foreach (Turno t in turnos)
                {
                    row = tablaRecursos.NewRow();
                    row["Inicio"] = t.FechaHoraInicio;
                    row["Fin"] = t.FechaHoraFin;
                    row["Cientifico"] = t.AsignacionCientifico.PC.Nombre.ToString();
                    row["Mail"] = t.AsignacionCientifico.PC.CorreoInstitu.ToString();
                    tablaRecursos.Rows.Add(row);
                }

                grillaTurnos.DataSource = tablaRecursos;
                grillaTurnos.Sort(grillaTurnos.Columns["Cientifico"], ListSortDirection.Ascending);

                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay listado de recursos tecnologicos");
            }
        }

        public void solicitarConfirmacion()
        {
            MessageBox.Show("Por favor confirme.");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla.activarBotonConfirmar();
        }
    }
}

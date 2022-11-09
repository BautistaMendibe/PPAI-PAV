using PPAI.Entidades;
using PPAI.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Interfaz
{
    public partial class VerRT : Form
    {

        private readonly RecursoTecnologicoServicio rtServicioBD;

        public VerRT()
        {
            InitializeComponent();
            rtServicioBD = new RecursoTecnologicoServicio();
        }

        private void VerRT_Load(object sender, EventArgs e)
        {
            consultarRecursosTecnologicos();
        }

        private void consultarRecursosTecnologicos()
        {
            var recursos = rtServicioBD.GetRecursos();
            foreach (RecursoTecnologico recursoTecnologico in recursos)
            {
                var fila = new string[] {
                // Lo ponemos en el orden donde están las columnas en la grilla
                recursoTecnologico.NumeroRT.ToString(),
                recursoTecnologico.Duracion.ToString(),
                recursoTecnologico.FraccionHorarioTurno.ToString(),
                recursoTecnologico.FraccionHorarioTurno.ToString(),
                recursoTecnologico.Periodicidad.ToString(),
                recursoTecnologico.IdMantenimiento.ToString(),
                recursoTecnologico.IdModelo.ToString(),
                recursoTecnologico.IdTipoRT.ToString(),
                recursoTecnologico.IdCambioEstadoRT.ToString(),
                recursoTecnologico.IdTurno.ToString(),
            };

                grillaRT.Rows.Add(fila);
            }
        }

    }
}

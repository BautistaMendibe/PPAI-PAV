using PPAI.Entidades;
using PPAI.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicio_Acceso_BD
{
    class TurnoServicioBD
    {
        private EstadoServicio estadoServicioBD = new EstadoServicio();
        private AsignacionCientificoDelCIServicio asignacionServicioBD = new AsignacionCientificoDelCIServicio();
        public List<Turno> getTurnosPorRT(int numeroRT)
        {
            var sql = $"SELECT * FROM Turno WHERE id_rt = {numeroRT}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var turnos = new List<Turno>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var turno = new Turno();
                turno.DiaSemana = fila["diaSemana"].ToString();
                turno.FechaGeneracion = Convert.ToDateTime(fila["fechaGeneracion"].ToString());
                turno.FechaHoraFin = Convert.ToDateTime(fila["fechaHoraFin"].ToString());
                turno.FechaHoraInicio = Convert.ToDateTime(fila["fechaHoraInicio"].ToString());

                int idEstado = Convert.ToInt32(fila["id_estado"].ToString());
                turno.Estado = estadoServicioBD.getEstado(idEstado);

                int idASignacion = Convert.ToInt32(fila["id_asignacion"].ToString());
                turno.AsignacionCientifico = asignacionServicioBD.getAsignacion(idASignacion);

                turnos.Add(turno);
            }

            return turnos;
        }
    }
}

using PPAI.Entidades;
using PPAI.Servicio_Acceso_BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    class CambioEstadoTurnoServicio
    {

        private EstadoServicio estadoServicioBD = new EstadoServicio();

        public List<CambioEstadoTurno> GetCambiosEstados(int numRT)
        {
            var sql = $"SELECT * FROM CambioEstadoTurno where id_turno = {numRT}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var cambiosEstadoTurno = new List<CambioEstadoTurno>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cambioEstadoTurno = new CambioEstadoTurno();

                cambioEstadoTurno.FechaHoraDesde = Convert.ToDateTime(fila["fechaHoraDesde"].ToString());

                if (fila["fechaHoraHasta"].Equals(DBNull.Value))
                {
                    cambioEstadoTurno.FechaHoraHasta = null;
                }
                else
                {
                    cambioEstadoTurno.FechaHoraHasta = Convert.ToDateTime(fila["fechaHoraHasta"]);
                }

                int idEstado = Convert.ToInt32(fila["id_estado"].ToString());
                cambioEstadoTurno.EstadoActual = estadoServicioBD.getEstado(idEstado);

                cambiosEstadoTurno.Add(cambioEstadoTurno);
            }

            return cambiosEstadoTurno;
        }
    }
}

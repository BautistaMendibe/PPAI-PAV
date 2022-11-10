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
    class CambioEstadoRTServicio
    {
        private EstadoServicio estadoServicioBD = new EstadoServicio();

        public List<CambioEstadoRT> GetCambiosEstados(int numRT)
        {
            var sql = $"SELECT * FROM CambioEstadoRT where id_rt = {numRT}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var cambiosEstadoRT = new List<CambioEstadoRT>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cambioEstadoRT = new CambioEstadoRT();

                cambioEstadoRT.FechaHoraDesde = Convert.ToDateTime(fila["fecahHoraDesde"].ToString());

                if (fila["fechaHoraHasta"].Equals(DBNull.Value))
                {
                    cambioEstadoRT.FechaHoraHasta = null;
                }
                else
                {
                    cambioEstadoRT.FechaHoraHasta = Convert.ToDateTime(fila["fechaHoraHasta"]);
                }

                int idEstado = Convert.ToInt32(fila["id_estado"].ToString());
                cambioEstadoRT.EstadoActual = estadoServicioBD.getEstado(idEstado);

                cambiosEstadoRT.Add(cambioEstadoRT);
            }

            return cambiosEstadoRT;
        }
    }
}

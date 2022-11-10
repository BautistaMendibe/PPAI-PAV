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
    class AsignacionResponsableTecnicoRTServicio
    {

        PersonalCientificoServicio personalCientificoServicioBD = new PersonalCientificoServicio();
        RecursoTecnologicoServicio recursoTecnologicoServicioBD = new RecursoTecnologicoServicio();

        public List<AsignaciónResponsableTecnicoRT> getAsignaciones()
        {
            var sql = $"SELECT * FROM AsignacionResponsableTecnicoRT";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var asignaciónResponsableTecnicoRTs = new List<AsignaciónResponsableTecnicoRT>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var asignacionResponsableTecnicoRT = new AsignaciónResponsableTecnicoRT();
                asignacionResponsableTecnicoRT.FechaDesde = Convert.ToDateTime(fila["fechaDesde"]);

                if (fila["fechaHasta"].Equals(DBNull.Value))
                {
                    asignacionResponsableTecnicoRT.FechaHasta = null;
                }
                else
                {
                    asignacionResponsableTecnicoRT.FechaHasta = Convert.ToDateTime(fila["fechaHasta"]);
                }

                int idPersonalCientifico = Convert.ToInt32(fila["id_personalCientifico"].ToString());
                asignacionResponsableTecnicoRT.PersonalCientifico = personalCientificoServicioBD.obtenerPersonalCientifico(idPersonalCientifico);

                int idAsignacionRT = Convert.ToInt32(fila["id"].ToString());
                asignacionResponsableTecnicoRT.RT = recursoTecnologicoServicioBD.GetRecursosPorAsignacion(idAsignacionRT);

                asignaciónResponsableTecnicoRTs.Add(asignacionResponsableTecnicoRT);
            }

            return asignaciónResponsableTecnicoRTs;
        }
    }
}

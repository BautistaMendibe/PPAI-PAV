using PPAI.Entidades;
using PPAI.Servicio_Acceso_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Servicios
{
    class RecursoTecnologicoServicio
    {
        public List<RecursoTecnologico> GetRecursos()
        {
            var sql = $"SELECT * FROM RecursoTecnologico";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var recursos = new List<RecursoTecnologico>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var recursoTecnologico = new RecursoTecnologico();
                recursoTecnologico.NumeroRT = Convert.ToInt32(fila["numeroRT"].ToString());
                recursoTecnologico.Duracion = Convert.ToInt32(fila["duracion"].ToString());
                recursoTecnologico.FechaAlta = Convert.ToDateTime(fila["fechaAlta"].ToString());
                recursoTecnologico.FraccionHorarioTurno = Convert.ToInt32(fila["fraccionHorarioTurno"].ToString());
                recursoTecnologico.Periodicidad = Convert.ToInt32(fila["periocidadMantenimientoPreventivo"].ToString());
                recursoTecnologico.IdMantenimiento = Convert.ToInt32(fila["id_mantenimiento"].ToString());
                recursoTecnologico.IdModelo = Convert.ToInt32(fila["id_modelo"].ToString());
                recursoTecnologico.IdTipoRT = Convert.ToInt32(fila["id_tipoRT"].ToString());
                //recursoTecnologico.IdCambioEstadoRT = Convert.ToInt32(fila["id_cambioEstadoRT"].ToString());
                //recursoTecnologico.IdTurno = Convert.ToInt32(fila["id_turno"].ToString());
                recursos.Add(recursoTecnologico);
            }

            return recursos;
        }
    }
}

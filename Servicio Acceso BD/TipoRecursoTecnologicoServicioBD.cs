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
    class TipoRecursoTecnologicoServicio
    {

        public TipoRecursoTecnológico getTipoRT(int idTipoRT)
        {
            var sql = $"SELECT * FROM TipoRecursoTecnologico WHERE id = {idTipoRT}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var tipo = new TipoRecursoTecnológico();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                tipo.Nombre = fila["nombre"].ToString();
            }

            return tipo;
        }
    }
}

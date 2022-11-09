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
    class SesionServicio
    {
        public Sesion getSesion()
        {
            Sesion sesion = new Sesion();
            var sql = $"SELECT * FROM Sesion WHERE id = 1;";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                sesion.FechaHoraInicio = Convert.ToDateTime(fila["fechaInicio"]);
                sesion.FechaHoraFin = Convert.ToDateTime(fila["fechaFin"]);
            }

            return sesion;
        }
    }
}

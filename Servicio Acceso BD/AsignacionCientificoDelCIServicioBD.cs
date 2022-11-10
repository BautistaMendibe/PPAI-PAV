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
    class AsignacionCientificoDelCIServicio
    {

        private PersonalCientificoServicio servicioPersonalCientificoBD = new PersonalCientificoServicio();

        public AsignaciónCientificoDelCI getAsignacion(int idASignacion)
        {
            var sql = $"SELECT * FROM AsignacionCientificoDelCI WHERE id = {idASignacion}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var asignacion = new AsignaciónCientificoDelCI();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                asignacion.FechaDesde = Convert.ToDateTime(fila["fechaDesde"].ToString());
                asignacion.FechaHasta = Convert.ToDateTime(fila["fechaHasta"].ToString());
                
                int idPersonal = Convert.ToInt32(fila["id_personalCientifico"].ToString());
                asignacion.PC = servicioPersonalCientificoBD.obtenerPersonalCientifico(idPersonal);
            }

            return asignacion;
        }

    }
}

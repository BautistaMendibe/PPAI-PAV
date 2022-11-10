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
    class EstadoServicio
    {

        public Estado getEstado(int id)
        {
            var sql = $"SELECT * FROM Estado WHERE id = {id};";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Estado estado = new Estado();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                estado.Id = Convert.ToInt32(fila["id"]);
                estado.Nombre = fila["nombre"].ToString();
                estado.Ambito = fila["ambito"].ToString();
            }

            return estado;
        }

        public bool esDisponible(int numeroRT)
        {
            var sql = $"SELECT * FROM RecursoTecnologico WHERE numeroRT = {numeroRT};";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            int estado = 0;

            foreach (DataRow fila in tablaResultado.Rows)
            {
                estado = Convert.ToInt32(fila["id_estado"]);
            }

            if (estado == 1)
            {
                return true;
            }

            return false;
        }
    }
}

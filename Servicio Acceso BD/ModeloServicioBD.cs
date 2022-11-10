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
    class ModeloServicio
    {

        public Modelo getModelo(int id)
        {
            var sql = $"SELECT * FROM Modelo WHERE id = {id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var modelo = new Modelo();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                modelo.Nombre = fila["nombre"].ToString();
            }

            return modelo;
        }

    }
}

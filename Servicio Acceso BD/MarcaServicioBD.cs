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
    class MarcaServicio
    {
        public Marca getMarca(int id_marca)
        {
            var sql = $"SELECT * FROM Marca WHERE id = {id_marca}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var marca = new Marca();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                marca.Nombre = fila["nombre"].ToString();
            }

            return marca;
        }
    }
}

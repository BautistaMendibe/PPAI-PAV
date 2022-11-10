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

        private MarcaServicio marcaServicioBD = new MarcaServicio();

        public Modelo getModelo(int id)
        {
            var sql = $"SELECT * FROM Modelo WHERE id = {id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var modelo = new Modelo();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                modelo.Nombre = fila["nombre"].ToString();
                int id_marca = Convert.ToInt32(fila["id_marca"].ToString());
                modelo.Marca = marcaServicioBD.getMarca(id_marca);
            }

            return modelo;
        }

    }
}

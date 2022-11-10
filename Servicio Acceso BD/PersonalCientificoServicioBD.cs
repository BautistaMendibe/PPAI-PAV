using PPAI.Entidades;
using PPAI.Servicio_Acceso_BD;
using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PPAI.Servicios
{
    class PersonalCientificoServicio
    {
        public PersonalCientifico obtenerPersonalCientifico()
        {
            var sql = $"SELECT * FROM PersonalCientifico WHERE legajo = 2;";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var personalCientifico = new PersonalCientifico();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                personalCientifico.Legajo = Convert.ToInt32(fila["legajo"]);
                personalCientifico.Nombre = fila["nombre"].ToString();
                personalCientifico.Apellido = fila["apellido"].ToString();
                personalCientifico.TelefonoCelular = Convert.ToInt32(fila["celular"]); ;
                personalCientifico.CorreoInstitu = fila["correoInstitucional"].ToString();
                personalCientifico.CorreoPersonal = fila["correoPersonal"].ToString();
                personalCientifico.NumeroDocumento = Convert.ToInt32(fila["numeroDocumento"]);
                personalCientifico.IdUsuarioActual = Convert.ToInt32(fila["id_usuario"]);
            }

            return personalCientifico;
        }


    }
}

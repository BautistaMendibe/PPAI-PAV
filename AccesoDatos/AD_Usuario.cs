using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Entidades;

namespace PPAI.AccesoDatos
{
    public class AD_Usuario
    {
                
        //public static bool ValidarExistenciaUsuario(string nombre)
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {
        //        bool resultado = false;
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "SELECT usuario FROM usuarios WHERE usuario = @nombre";

        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@nombre", nombre);

        //        //cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = consulta;
        //        cn.Open();
        //        cmd.Connection = cn;

        //        DataTable tabla = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);

        //        if (tabla.Rows.Count >= 1)
        //        {
        //            resultado = true;
        //        }
        //        else
        //        {
        //            resultado = false;
        //        }

        //        return resultado;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //} 
    }
}

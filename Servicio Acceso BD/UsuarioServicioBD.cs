using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicio_Acceso_BD
{
    class UsuarioServicioBD
    {

        public List<Usuario> obtenerUsuariosRegistrados()
        {
            var sql = $"SELECT * FROM Usuario";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var usuarios = new List<Usuario>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuario = new Usuario();
                usuario.NombreDeUsuario = fila["descripcion"].ToString();
                usuario.Password = fila["password"].ToString();
                usuarios.Add(usuario);
            }

            return usuarios;
        }

        public Usuario obtenerPersonal()
        {
            var usuarioLogeado = new Usuario();
            var sql = $"SELECT * FROM Usuario WHERE id=1";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                usuarioLogeado.NombreDeUsuario = fila["descripcion"].ToString();
                usuarioLogeado.Password = fila["password"].ToString();
            }

            return usuarioLogeado;
        }
    }
}

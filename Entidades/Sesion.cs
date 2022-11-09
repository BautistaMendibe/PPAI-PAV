using PPAI.AccesoDatos;
using PPAI.Servicio_Acceso_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Entidades
{
    public class Sesion
    {

        private DateTime fechaHoraFin;
        private DateTime fechaHoraInicio;
        private Usuario usuarioSeleccionado;
        private List<Usuario> usuariosRegistrados;
        private UsuarioServicioBD usuariosServicioBD;

        public Sesion()
        {
            usuariosServicioBD = new UsuarioServicioBD();
        }

        public Sesion(DateTime fechaHoraFin, DateTime fechaHoraInicio, Usuario usuarioSeleccionado)
        {
            this.fechaHoraFin = fechaHoraFin;
            this.fechaHoraInicio = fechaHoraInicio;
            this.usuarioSeleccionado = usuarioSeleccionado;
            usuariosServicioBD = new UsuarioServicioBD();
        }

        public DateTime FechaHoraInicio
        {
            get => this.fechaHoraInicio;
            set => this.fechaHoraInicio = value;
        }

        public DateTime FechaHoraFin
        {
            get => this.fechaHoraFin;
            set => this.fechaHoraFin = value;
        }

        public Usuario UsuarioSeleccionado
        {
            get => this.usuarioSeleccionado;
            set => this.usuarioSeleccionado = value;
        }

        public Usuario mostrarCientifico()
        {   
            this.UsuarioSeleccionado = usuariosServicioBD.obtenerPersonal();
            return this.usuarioSeleccionado;
        }

    }
}

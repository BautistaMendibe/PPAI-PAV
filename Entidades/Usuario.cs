using PPAI.AccesoDatos;
using PPAI.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Usuario
    {
        private string usuario;
        private string clave;
        private bool habilitado;
        private PersonalCientificoServicio PersonalCientificoServicioBD;

        public Usuario()
        {
            PersonalCientificoServicioBD = new PersonalCientificoServicio();
        }

        public Usuario(string nombreUsuario, string password, bool habilitado)
        {
            this.usuario = nombreUsuario;
            this.clave = password;
            this.habilitado = habilitado;
        }

        public string NombreDeUsuario
        {
            get => this.usuario;
            set => this.usuario = value;
        }

        public string Password
        {
            get => clave;
            set => clave = value;
        }

        public bool Habilitar
        {
            get => habilitado; 
            set => habilitado = true;
        }

        public bool Inhabilitar
        {
            get => habilitado;
            set => habilitado = false;
        }

        public PersonalCientifico obtenerPersonalCientifico()
        {
            var personalCientifico = PersonalCientificoServicioBD.obtenerPersonalCientifico();
            return personalCientifico;
        }
    }
}

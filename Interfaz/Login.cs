using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Entidades;
using PPAI.Servicio_Acceso_BD;

namespace PPAI.Interfaz
{
    public partial class Login : Form
    {
        private UsuarioServicioBD usuariosServicioBD;

        public Login()
        {
            InitializeComponent();
            usuariosServicioBD = new UsuarioServicioBD();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //DateTime horaInicio = DateTime.Now;
            //Sesion sesionActual = new Sesion(horaInicio, horaInicio, null);
            //Usuario se = sesionActual.esTuUsuario(txtNombreUsuario.Text, txtContraseña.Text, sesionActual);

            //sesionActual.UsuarioSeleccionado = se;

            bool existe = verificarExistenciaUsuario(txtNombreUsuario.Text, txtContraseña.Text);

            if (existe == true)
            {
                Principal menuPrincipal = new Principal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los valores ingresados son incorrectos");
            }
        }

        private bool verificarExistenciaUsuario(string nombreUsuario, string password)
        {
            List<Usuario> usuarios_registrados = usuariosServicioBD.obtenerUsuariosRegistrados();

            foreach(Usuario usuario in usuarios_registrados)
            {
                if (usuario.NombreDeUsuario.Trim() == nombreUsuario && usuario.Password.Trim() == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

    }
}

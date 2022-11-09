using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Controlador;
using PPAI.Entidades;
using PPAI.Servicios;

namespace PPAI.Interfaz
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }


        private void btnprobar_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            RegistrarIngresoRTMantenimientoCorrectivo ventana = new RegistrarIngresoRTMantenimientoCorrectivo();
            this.Hide();
            ventana.Show();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

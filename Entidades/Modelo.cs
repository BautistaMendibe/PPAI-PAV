using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;
using PPAI.Servicios;

namespace PPAI.Entidades
{
    public class Modelo
    {
        private int id;
        private string nombre;
        private Marca marca;

        private int Id
        {
            get => id; set => id = value; 
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public Marca Marca
        {
            get => marca;
            set => marca = value;
        }

        public Modelo()
        {

        }

        public Modelo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public (string,string) mostrarMarcaYModelo()
        {

            string nombreMarca = marca.mostrarNombre();
            return (nombre.Trim(), nombreMarca.Trim());
        }
    }
}

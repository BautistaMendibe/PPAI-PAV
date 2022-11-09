using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;

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
            Marca marca = Datos.marca1;
            for (int i = 0; i < marca.Modelos.Count; i++)
            {
                if (marca.Modelos[i].Nombre.ToString().Equals(this.Nombre.ToString()))
                {
                    this.marca = marca;
                    string nombreMarca = marca.mostrarNombre();
                    string nombreModelo = this.Nombre.ToString();
                    return (nombreMarca, nombreModelo);
                }
            }
            return (null,null);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;

namespace PPAI.Entidades
{
    public class Marca
    {
        private int id;
        private string nombre;
        private List<Modelo> modelos;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public List<Modelo> Modelos 
        { 
            get => modelos; set => modelos = value;
        }

        public Marca()
        {

        }

        public Marca(int id, string nombre, List<Modelo> modelos)
        {
            this.id = id;
            this.nombre = nombre;
            this.modelos = modelos;
        }

        public string mostrarNombre()
        {
            return this.Nombre.ToString();
        }
    }
}

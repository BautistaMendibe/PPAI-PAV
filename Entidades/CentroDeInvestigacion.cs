using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CentroDeInvestigacion
    {
        private string nombre;
        private List<RecursoTecnologico> recursosTecnologicos;
        private List<AsignaciónCientificoDelCI> asignaci;

        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }

        public List<RecursoTecnologico> RecursosTecnologicos
        {
            get => this.recursosTecnologicos;
            set => this.recursosTecnologicos = value;
        }

        public List<AsignaciónCientificoDelCI> AsignaciónCientificoDelCIs
        {
            get => this.asignaci;
            set => this.asignaci = value;
        }

        public CentroDeInvestigacion()
        {

        }

        public CentroDeInvestigacion(string nombre, List<RecursoTecnologico> recursosTecnologicos, List<AsignaciónCientificoDelCI> asignaci)
        {
            this.nombre = nombre;
            this.recursosTecnologicos = recursosTecnologicos;
            this.asignaci = asignaci;
            
        }

        public bool esDeCentroDeInvestigacion(CentroDeInvestigacion ci, Sesion sesion)
        {
            for (int i = 0; i < ci.asignaci.Count; i++)
            {
                bool esCentroInve = asignaci[i].esDeCentroDeInvestigacion(sesion.UsuarioSeleccionado);
                if (esCentroInve)
                {
                    return true;
                }

            }
            return false;
        }
    }
}

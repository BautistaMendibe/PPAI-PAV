using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class AsignaciónResponsableTecnicoRT
    {
        private DateTime? fechaDesde;
        private DateTime? fechaHasta;
        private List<RecursoTecnologico> rt;
        private PersonalCientifico personal;

        public DateTime? FechaDesde
        {
            get => fechaDesde;
            set => fechaDesde = value;
        }

        public DateTime? FechaHasta
        {
            get => fechaHasta;
            set => fechaHasta = value;
        }

        public List<RecursoTecnologico> RT
        {
            get => rt;
            set => rt = value;
        }

        public PersonalCientifico PersonalCientifico
        {
            get => personal; set => personal = value;
        }

        public AsignaciónResponsableTecnicoRT()
        {

        }
        public AsignaciónResponsableTecnicoRT(DateTime? fechaDesde, DateTime? fechaHasta, List<RecursoTecnologico> rt, PersonalCientifico personal)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.rt = rt;
            this.personal = personal;
        }

        public List<RecursoTecnologico> obtenerRTDisponibles(AsignaciónResponsableTecnicoRT ra)
        {
            rt = ra.RT;
            List<string> datos = new List<string>();
            //string tipo, modelo, marca;
            for (int i = 0; i < rt.Count; i++)
            {
                bool esDispo = rt[i].esDisponible(rt[i]);
                if (!esDispo)
                {
                    rt.RemoveAt(i);
                }
            }

            for (int i = 0; i < rt.Count; i++)
            {
                if (rt[i] != null)
                {
                    (int num, string tipo, string marca, string modelo) = rt[i].mostrarDatosRT(rt[i]);
                    datos.Add(num.ToString());
                    datos.Add(tipo);
                    datos.Add(marca);
                    datos.Add(modelo);
                }
            }
            return rt;
        }

        public bool esAsignacionVigenteCientifico(AsignaciónResponsableTecnicoRT asignacion)
        {
            return esViegente(asignacion);
            
        }

        private bool esViegente(AsignaciónResponsableTecnicoRT asignaciones)
        {
            if (asignaciones.FechaHasta.Equals(null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

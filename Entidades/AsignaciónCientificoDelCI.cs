using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class AsignaciónCientificoDelCI
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private PersonalCientifico pc;
        private List<Turno> turno;

        public DateTime FechaDesde
        {
            get => fechaDesde;
            set => fechaDesde = value;
        }

        public DateTime FechaHasta
        {
            get => fechaHasta;
            set => fechaHasta = value;
        }

        public PersonalCientifico PC
        {
            get => pc;
            set => pc = value;
        }

        public List<Turno> Turno
        {
            get => turno; set => turno = value;
        }

        public AsignaciónCientificoDelCI()
        {

        }

        public AsignaciónCientificoDelCI(DateTime fechaDesde, DateTime fechaHasta, PersonalCientifico pc, List<Turno> turnos)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.pc = pc;
            this.turno = turnos;
            
        }

        public bool esDeCentroDeInvestigacion(Usuario usuario)
        {
            if (usuario.NombreDeUsuario.ToString() == PC.UsuarioActual.ToString())
            {
                return true;
            }
            return false;
        }

        public (string,string) mostrarDatosCientifico(Turno t)
        {
            for (int i = 0; i < turno.Count; i++)
            {
                if (turno[i] == t)
                {
                    string nom = this.pc.getNombre();
                    string mail = this.PC.getMail();
                    return (nom, mail);
                }
            }
            return (null,null);
        }
    }
}

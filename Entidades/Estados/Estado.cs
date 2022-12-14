using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades.Estados
{
    abstract class Estado
    {
        public string nombre;
        public string ambito;


        abstract public void ingresarEnMantenimientoCorrectivo(DateTime time, DateTime fechaFinPrev, string motivo, List<CambioEstadoRT> cambiosEstadosRT, RecursoTecnologico rt);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades.Estados
{
    class IngresadoEnMantenimientoCorrectivo : Estado
    {
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }

        public override void ingresarEnMantenimientoCorrectivo(DateTime time, DateTime fechaFinPrev, string motivo, List<CambioEstadoRT> cambiosEstadosRT)
        {
            Console.WriteLine("Nada");
        }
    }
        
}

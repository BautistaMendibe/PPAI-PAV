using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades.Estados
{
    class DisponibleRT : Estado
    {
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }
        private CambioEstadoRT ultimoCambioRT;

        public override void ingresarEnMantenimientoCorrectivo(DateTime time, DateTime fechaFinPrev, string motivo, List<CambioEstadoRT> cambiosEstadosRT){
            CambioEstadoRT actualCambioEstado = buscarHistorialRTActual(cambiosEstadosRT);
            actualCambioEstado.setFechaFin(time);

            IngresadoEnMantenimientoCorrectivo nuevoEstado = crearEstadoIngresadoEnMantenimientoCorrectivo();
            //CambioEstadoRT nuevoHistorial = crearNuevoHistorialRT(time, nuevoEstado);
        }

        private CambioEstadoRT buscarHistorialRTActual(List<CambioEstadoRT> cambiosEstadosRT)
        {
            foreach (CambioEstadoRT cambioEstadoRT in cambiosEstadosRT)
            {
                if (cambioEstadoRT.esActual())
                {
                    ultimoCambioRT = cambioEstadoRT;
                }
            }
            return ultimoCambioRT;
        }

        private IngresadoEnMantenimientoCorrectivo crearEstadoIngresadoEnMantenimientoCorrectivo()
        {
            IngresadoEnMantenimientoCorrectivo  estadoIngresadoEnMantenimientoCorrectivo = new IngresadoEnMantenimientoCorrectivo();
            return estadoIngresadoEnMantenimientoCorrectivo;
        }

        //private CambioEstadoRT crearNuevoHistorialRT(DateTime fechaHoraInicio, IngresadoEnMantenimientoCorrectivo estado)
        //{
        //    CambioEstadoRT historialEstadoRT = new CambioEstadoRT(fechaHoraInicio, null, estado);
        //    return historialEstadoRT;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Servicios;

namespace PPAI.Entidades.Estados
{
    class DisponibleRT : Estado
    {
        public string Nombre { get => nombre; set => nombre = value; }
        private static EstadoServicio es = new EstadoServicio();
        public Entidades.Estado estadoManntenC = es.getEstado(6);
        public string Ambito { get => ambito; set => ambito = value; }
        private CambioEstadoRT ultimoCambioRT;



        public override void ingresarEnMantenimientoCorrectivo(DateTime time, DateTime fechaFinPrev, string motivo, List<CambioEstadoRT> cambiosEstadosRT, RecursoTecnologico rt){
            CambioEstadoRT actualCambioEstado = buscarHistorialRTActual(cambiosEstadosRT);
            actualCambioEstado.setFechaFin(time);

            IngresadoEnMantenimientoCorrectivo estadoMantenC = crearEstadoIngresadoEnMantenimientoCorrectivo();
            CambioEstadoRT nuevoHistorial = crearNuevoHistorialRT(time, estadoMantenC);
            Mantenimiento nuevoMantenimiento = crearNuevoMantenimiento(null, fechaFinPrev, fechaFinPrev, motivo);

            rt.agregarHistorialRT(nuevoHistorial);
            rt.setEstado(estadoManntenC);
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
            IngresadoEnMantenimientoCorrectivo estadoMantenC = new IngresadoEnMantenimientoCorrectivo();
            return estadoMantenC;
        }

        private CambioEstadoRT crearNuevoHistorialRT(DateTime fechaHoraInicio, IngresadoEnMantenimientoCorrectivo estado)
        {
            CambioEstadoRT historialEstadoRT = new CambioEstadoRT(fechaHoraInicio, null, estadoManntenC);
            return historialEstadoRT;
        }

        private Mantenimiento crearNuevoMantenimiento(DateTime? fechaFin, DateTime? fechaInicio, DateTime? fechaInicioPrevista, string motivoMantenimiento)
        {
            Mantenimiento nuevoMantenimiento = new Mantenimiento(fechaFin, fechaInicio, fechaInicioPrevista, motivoMantenimiento);
            return nuevoMantenimiento;
        }
    }
}

using PPAI.Entidades.Estados;
using PPAI.Servicio_Acceso_BD;
using PPAI.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class RecursoTecnologico
    {
        private int numeroRT;
        private DateTime fechaAlta;
        private string imagenes;
        private int periodicidadMantenimientoPrev;
        private int duracionMantenimientoPrev;
        private int fraccionHorarioTurnos;
        private List<Turno> turnos;
        private TipoRecursoTecnológico tipoRecurso;
        private Modelo modelo;
        private List<CambioEstadoRT> cambioEstado;
        //private List<Mantenimiento> mantenimiento;
        private CambioEstadoRT cambioEstadoActual;
        //private List<CambioEstadoTurno> cambioEstadoTurno;
        private Mantenimiento mantenimiento;
        private int id_mantenimiento;
        private int id_modelo;
        private int id_tipoRT;
        private int id_CambioEstadoRT;
        private int id_turno;

        private Estado estado;
        private DisponibleRT estadoDisponibleRT;
        private EstadoServicio estadoServicioBD;
        private TurnoServicioBD turnoServicioBD;
        private List<Turno> turnosRT;


        // Constructor
        public RecursoTecnologico()
        {
            estadoServicioBD = new EstadoServicio();
            turnoServicioBD = new TurnoServicioBD();
            estadoDisponibleRT = new DisponibleRT();
        }

        public int NumeroRT
        {
            get => numeroRT; set => numeroRT = value;
        }

        public DateTime FechaAlta
        {
            get => fechaAlta; set => fechaAlta = value;
        }

        public string Imagenes
        {
            get => imagenes; set => imagenes = value;
        }

        public int Periodicidad
        {
            get => periodicidadMantenimientoPrev; set => periodicidadMantenimientoPrev = value;
        }

        public int Duracion
        {
            get => duracionMantenimientoPrev; set => duracionMantenimientoPrev = value;
        }

        public int FraccionHorarioTurno
        {
            get => fraccionHorarioTurnos; set => fraccionHorarioTurnos = value;
        }

        public List<Turno> Turnos
        {
            get => turnos; set => turnos = value;
        }

        public TipoRecursoTecnológico TipoRecurso
        {
            get => tipoRecurso; set => tipoRecurso = value;
        }

        public Modelo Modelo
        {
            get => modelo; set => modelo = value;
        }

        public List<CambioEstadoRT> CambioEstado
        {
            get => cambioEstado; set => cambioEstado = value;
        }

        public Mantenimiento Mantenimiento
        {
            get => mantenimiento; set => mantenimiento = value;
        }

        public Estado Estado
        {
            get => estado; set => estado = value;
        }

        public int IdMantenimiento
        {
            get => id_mantenimiento; set => id_mantenimiento = value;
        }

        public int IdModelo
        {
            get => id_modelo; set => id_modelo = value;
        }

        public int IdTipoRT
        {
            get => id_tipoRT; set => id_tipoRT = value;
        }

        public int IdCambioEstadoRT
        {
            get => id_CambioEstadoRT; set => id_CambioEstadoRT = value;
        }

        public int IdTurno
        {
            get => id_turno; set => id_turno = value;
        }

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, string imagenes, int periodicidadMantenimientoPrev, int duracionMantenimientoPrev, int fraccionHorarioTurnos, List<Turno> turnos, TipoRecursoTecnológico tipoRecurso, Modelo modelo, List<CambioEstadoRT> cambioEstado)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagenes = imagenes;
            this.periodicidadMantenimientoPrev = periodicidadMantenimientoPrev;
            this.duracionMantenimientoPrev = duracionMantenimientoPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
            this.turnos = turnos;
            this.tipoRecurso = tipoRecurso;
            this.modelo = modelo;
            this.cambioEstado = cambioEstado;
        }

        public bool esDisponible(RecursoTecnologico rt)
        {

            bool esDisponible = estadoServicioBD.esDisponible(rt.numeroRT);
            return esDisponible;

            //cambioEstado = rt.CambioEstado;
            //for (int i = 0; i < cambioEstado.Count; i++)
            //{
            //    bool esActual = cambioEstado[i].esActual(cambioEstado[i]);
            //    if (esActual)
            //    {
            //        bool esDisp = cambioEstado[i].esDisponible(cambioEstado[i]);
            //        if (esDisp)
            //        {
            //            this.cambioEstadoActual = cambioEstado[i];
            //            return true;
            //        }
            //    }
            //}

        }

        public (int,string,string,string) mostrarDatosRT(RecursoTecnologico rt)
        {
            int num = getNumero(rt);
            string tipo = rt.TipoRecurso.getNombre().Nombre;
            (string marca, string modelo) = rt.Modelo.mostrarMarcaYModelo();
            
            return (num,tipo,marca,modelo);
        }

        public int getNumero(RecursoTecnologico rt)
        {
            return rt.NumeroRT;
        }

        public List<Turno> obtenerTurnosCancelablesEnPeriodo(DateTime fechaFinPrevistaSeleccionada)
        {
            this.turnosRT = turnoServicioBD.getTurnosPorRT(this.numeroRT);

            for (int i = turnosRT.Count - 1; i >= 0; i--)
            {
                if (turnosRT[i].esCancelableEnPeriodo(fechaFinPrevistaSeleccionada) == false)
                {
                    turnosRT.Remove(turnosRT[i]);
                }
            }

            return turnosRT;
        }

        public List<Turno> mostrarTurnosReserva()
        {
            for (int i = turnosRT.Count - 1; i >= 0; i--)
            {
                if (turnosRT[i].esConReserva() == false)
                {
                    turnosRT.Remove(turnosRT[i]);
                }
            }

            foreach (Turno turno in this.turnosRT)
            {
                turno.mostrarDatosTurno();
            }
            return this.turnosRT;
        }

        public void ingresarEnMantenimientoCorrectivo(DateTime time, DateTime fechaFinPrev, string motivo)
        {
            estadoDisponibleRT.ingresarEnMantenimientoCorrectivo(time, fechaFinPrev, motivo, cambioEstado);
        }

        public void cancelarTurnos(DateTime time, Estado estadoRT)
        {
            foreach(Turno turno in this.turnos)
            {
                turno.setFechaFin(time, estadoRT);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Entidades;
using PPAI.Interfaz;
using PPAI.AccesoDatos;
using PPAI.Servicios;

namespace PPAI.Controlador
{
    public class GestorRegistrarIngresoRTMantenimientoCorrectivo
    {
        private RegistrarIngresoRTMantenimientoCorrectivo pantalla;
        private List<RecursoTecnologico> lisRT;
        private RecursoTecnologico rt;
        private Estado estado;
        private List<AsignaciónResponsableTecnicoRT> asigResTecRT;
        private AsignaciónResponsableTecnicoRT ra;
        private PersonalCientifico pc;
        private RecursoTecnologico rtSelec;
        private DateTime fechaFinPrevistaSeleccionada;
        private DateTime timeActual;
        private string razonMantenimientoIngresado;
        private List<Turno> listaTurnos;
        private Estado esConfMCorr;
        private Estado esEnMCorr;
        private PersonalCientificoServicio personalCientificoServicioBD;
        private SesionServicio sesionServicioBD;
        private Usuario personalLogeado;
        private AsignacionResponsableTecnicoRTServicio asignacionResponsableTecnicoRTServicioBD;



        public GestorRegistrarIngresoRTMantenimientoCorrectivo()
        {
        }

        public GestorRegistrarIngresoRTMantenimientoCorrectivo(RegistrarIngresoRTMantenimientoCorrectivo pantalla)
        {
            this.pantalla = pantalla;
            personalCientificoServicioBD = new PersonalCientificoServicio();
            sesionServicioBD = new SesionServicio();
            asignacionResponsableTecnicoRTServicioBD = new AsignacionResponsableTecnicoRTServicio();
        }

        public void registrarIngresoRTMantenimientoCorrectivo()
        {
            
            Usuario usuarioLogueado = obtenerUsuarioLogueado();

            PersonalCientifico pc = usuarioLogueado.obtenerPersonalCientifico();

            ra = obtenerRTCientifico(pc);

            //Obtener RTDisponibles para la asignacion responsable tecnico RT
            (lisRT) = obtenerRTDisponibles(ra);
            pantalla.cargarGrillaRTDisponibles(lisRT);
            pantalla.solicitarSeleccionRT();
            
        }       

        public Usuario obtenerUsuarioLogueado()
        {
            Sesion sesion = sesionServicioBD.getSesion();
            Usuario usuario = sesion.mostrarCientifico();

            return usuario;
        }

        public AsignaciónResponsableTecnicoRT obtenerRTCientifico(PersonalCientifico pc)
        {
            List<AsignaciónResponsableTecnicoRT> asigResTecRT = asignacionResponsableTecnicoRTServicioBD.getAsignaciones();

            foreach (AsignaciónResponsableTecnicoRT asignacion in asigResTecRT)
            {
                if (asignacion.PersonalCientifico.Legajo.Equals(pc.Legajo))
                {
                    bool esVigente = asignacion.esAsignacionVigenteCientifico(asignacion);
                    if (esVigente)
                    {
                        ra = asignacion;
                    }
                }                
            }
            return ra;
        }

        private List<RecursoTecnologico> obtenerRTDisponibles(AsignaciónResponsableTecnicoRT ra)
        {
            lisRT = ra.obtenerRTDisponibles(ra);
            if (lisRT.Count == 0)
            {
                pantalla.aviso();
            }
            
            return lisRT;
        }

        public RecursoTecnologico rtSeleccionado(string numero)
        {
            for (int i = 0; lisRT.Count > i; i++)
            {
                if (lisRT[i].NumeroRT.ToString().Equals(numero))
                {
                    rtSelec = lisRT[i];
                }
            }
            return rtSelec;
        }

        public void fechaFinPrevista(DateTime fechaFin)
        {
            this.fechaFinPrevistaSeleccionada = fechaFin;
        }

        public void razonMantenimiento(string razon)
        {
            this.razonMantenimientoIngresado = razon;
            paso();
        }

        public void paso()
        {
            timeActual = obtenerFechaHora();
            listaTurnos = obtenerTurnosRTCancelables();
            
            if (listaTurnos != null)
            {
                pantalla.aviso2();
            }
            else
            {
                obtenerReservasVigentes();
            }

        }

        public DateTime obtenerFechaHora()
        {
            return timeActual = DateTime.Now;
        }

        public List<Turno> obtenerTurnosRTCancelables()
        {
            listaTurnos = this.rtSelec.obtenerTurnosCancelablesEnPeriodo(listaTurnos, fechaFinPrevistaSeleccionada);
            return listaTurnos;
        }

        public void obtenerReservasVigentes()
        {
            listaTurnos = this.rtSelec.mostrarTurnosReserva(listaTurnos);
            pantalla.cargarTurnos(listaTurnos);
        }

        public void agruparPorCientifico()
        {

        }

        public void ingresarRTMantenimientoCorrectivo(bool ban)
        {
            obtenerEstado();
            rtSelec.ingresarEnMantenimientoCorrectivo(timeActual, fechaFinPrevistaSeleccionada, razonMantenimientoIngresado,esConfMCorr);
            if (ban)
            {
                rtSelec.cancelarTurnos(timeActual, esConfMCorr);
            }
            
        }

        public void obtenerEstado()
        {
            List<Estado> listaEstado = Datos.conocerEstados();
            for (int i = 0; i < listaEstado.Count; i++)
            {
                bool esAT = listaEstado[i].esAmbitoTurno(listaEstado[i]);
                bool esCMC = listaEstado[i].esCanceladoMantenimientoCorrectivo(listaEstado[i]);
                if (esAT && esCMC)
                {
                    esConfMCorr = listaEstado[i];
                }
                bool esART = listaEstado[i].esAmbitoRT(listaEstado[i]);
                bool esEnMC = listaEstado[i].esEnMantenimientoCorrectivo(listaEstado[i]);
                if (esAT && esCMC)
                {
                    esEnMCorr = listaEstado[i];
                }
            }
        }

        public void generarMail()
        {
            Notificacion ventanaN = new Notificacion();
            ventanaN.Show();
            ventanaN.cargarDatos(rtSelec,listaTurnos);
        }

        public void finCU()
        {
            
        }
    }    
}

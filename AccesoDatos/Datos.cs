using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Entidades;

namespace PPAI.AccesoDatos
{
    public class Datos
    {
        //public static readonly DateTime date1 = new DateTime(2022, 05, 10, 08, 30, 52);
        //public static readonly DateTime date2 = new DateTime(2022, 06, 01, 08, 30, 52);
        //public static readonly DateTime date3 = new DateTime(2022, 06, 15, 08, 30, 52);
        //public static readonly DateTime date4 = new DateTime(2022, 06, 11, 08, 30, 52);

        //public static readonly AsignaciónCientificoDelCI asigCienti = new AsignaciónCientificoDelCI(date1, date2, new PersonalCientifico(25, "Mora", "Lopez", 36985214, "usuario1@facultad.com", "usuario1@gmail.com", 351669784, usuario), agregarTurnos());

        //public static readonly Mantenimiento mantenimiento = new Mantenimiento();

        //public static readonly Marca marca1 = new Marca(1, "SuperSu", agregarModelo());

        //public static readonly PersonalCientifico pc = new PersonalCientifico(25, "Julian", "Lopez", 36985214, "usuario1@facultad.com", "usuario1@gmail.com", 351669784, usuario);

        //public static readonly Sesion sesion = new Sesion(DateTime.Now, DateTime.Now, usuario);

        //public static readonly Usuario usuario = new Usuario("admin", "admin", true);
        //public static readonly Usuario usuario2 = new Usuario("admin", "1234", false);

        //public static readonly CentroDeInvestigacion ci = new CentroDeInvestigacion("Centro 1", agregarRT(), agregarAsignacion());

        //public static List<AsignaciónResponsableTecnicoRT> crearAsignaciones()
        //{
        //    List<AsignaciónResponsableTecnicoRT> asigna = new List<AsignaciónResponsableTecnicoRT>();
        //    asigna.Add(new AsignaciónResponsableTecnicoRT(date1, null, agregarRT(), new PersonalCientifico(25, "Julian", "Lopez", 36985214, "usuario1@facultad.com", "usuario1@gmail.com", 351669784, usuario)));
        //    asigna.Add(new AsignaciónResponsableTecnicoRT(date1, null, agregarRT(), new PersonalCientifico(25, "Julian", "Lopez", 36985214, "usuario1@facultad.com", "usuario1@gmail.com", 351669784, usuario)));
        //    asigna.Add(new AsignaciónResponsableTecnicoRT(date1, date2, agregarRT(), new PersonalCientifico(121, "Mush", "Lopez", 14785236, "usuario2@facultad.com", "usuario2@gmail.com", 351688695, usuario2)));
        //    asigna.Add(new AsignaciónResponsableTecnicoRT(date1, date2, agregarRT(), new PersonalCientifico(121, "Mush", "Lopez", 14785236, "usuario2@facultad.com", "usuario2@gmail.com", 351688695, usuario2)));

        //    return asigna;
        //}

        //private static List<RecursoTecnologico> agregarRT()
        //{
        //    List<RecursoTecnologico> list = new List<RecursoTecnologico>();

        //    list.Add(new RecursoTecnologico(1, date1, "imagen", 10, 20, 5, agregarTurnos(), new TipoRecursoTecnológico(1, "Balanza", "Tipo1"), new Modelo(1, "Systel"), agregarCamEstado()));
        //    list.Add(new RecursoTecnologico(2, date1, "imagen", 10, 20, 5, agregarTurnos(), new TipoRecursoTecnológico(2, "Telescopio", "Tipo2"), new Modelo(2, "Celestron"), agregarCamEstado()));
        //    list.Add(new RecursoTecnologico(3, date1, "imagen", 10, 20, 5, agregarTurnos(), new TipoRecursoTecnológico(3, "Computadora", "Tipo3"), new Modelo(3, "Intel"), agregarCamEstado()));
        //    list.Add(new RecursoTecnologico(4, date1, "imagen", 10, 20, 5, agregarTurnos(), new TipoRecursoTecnológico(1, "Libros", "Tipo1"), new Modelo(1, "Salamandra"), agregarCamEstado()));
        //    list.Add(new RecursoTecnologico(5, date1, "imagen", 10, 20, 5, agregarTurnos(), new TipoRecursoTecnológico(2, "Osciloscopio", "Tipo2"), new Modelo(2, "Ya-xun"), agregarCamEstado()));
        //    return list;
        //}

        //private static List<Turno> agregarTurnos()
        //{
        //    List<Turno> turnos = new List<Turno>();

        //    turnos.Add(new Turno(1, date1, "Lunes", date2, date4, agregarCambioEstado()));
        //    turnos.Add(new Turno(2, date1, "Martes", date2, date3, agregarCambioEstado()));
        //    turnos.Add(new Turno(3, date1, "Miercoles", date2, date4, agregarCambioEstado()));
        //    turnos.Add(new Turno(4, date1, "Viernes", date2, date3, agregarCambioEstado()));
        //    return turnos;
        //}

        //private static List<Modelo> agregarModelo()
        //{
        //    List<Modelo> lis = new List<Modelo>();

        //    lis.Add(new Modelo(1, "Systel"));
        //    lis.Add(new Modelo(2, "Celestron"));
        //    lis.Add(new Modelo(3, "Intel"));
        //    lis.Add(new Modelo(4, "Salamandra"));
        //    lis.Add(new Modelo(5, "Ya-xun"));

        //    return lis;
        //}

        //private static List<CambioEstadoRT> agregarCamEstado()
        //{
        //    List<CambioEstadoRT> list = new List<CambioEstadoRT>();

        //    //list.Add(new CambioEstadoRT(date1, date1, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false)));
        //    //list.Add(new CambioEstadoRT(date1, date2, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false)));
        //    //list.Add(new CambioEstadoRT(date2, date3, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false)));
        //    //list.Add(new CambioEstadoRT(date3, null, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false)));
        //    //list.Add(new CambioEstadoRT(date1, date4, new Estado(6, "EnMantenimientoCorrectivo", "Descripcion", "Recurso Tecnologico", false, false)));

        //    return list;

        //}

        //private static List<CambioEstadoTurno> agregarCambioEstado()
        //{
        //    List<CambioEstadoTurno> list = new List<CambioEstadoTurno>();

        //    list.Add(new CambioEstadoTurno(date1, date2, new Estado(2, "Cancelable", "Descripcion", "Turno", false, true)));
        //    list.Add(new CambioEstadoTurno(date2, date3, new Estado(3, "Reservado", "Descripcion", "Turno", true, false)));
        //    list.Add(new CambioEstadoTurno(date2, date3, new Estado(5, "CanceladoMantenimientoCorrectivo", "Descripcion", "Turno", false, false)));
        //    list.Add(new CambioEstadoTurno(date4, null, new Estado(4, "PendienteConfirmacionReserva", "Descripcion", "Turno", true, true)));

        //    return list;
        //}

        //private static List<AsignaciónCientificoDelCI> agregarAsignacion()
        //{
        //    List<AsignaciónCientificoDelCI> list = new List<AsignaciónCientificoDelCI>();

        //    list.Add(asigCienti);

        //    return list;
        //}

        ////public static readonly TipoRecursoTecnológico trt1 = new TipoRecursoTecnológico(1, "Tipo1", "Tipo1");
        ////public static readonly TipoRecursoTecnológico trt2 = new TipoRecursoTecnológico(2, "Tipo2", "Tipo2");
        ////public static readonly TipoRecursoTecnológico trt3 = new TipoRecursoTecnológico(3, "Tipo3", "Tipo3");
        ////public static readonly TipoRecursoTecnológico trt4 = new TipoRecursoTecnológico(4, "Tipo4", "Tipo4");

        ////public static readonly Turno turno1 = new Turno(1, date1, "Lunes",date2,date3,agregarCambioEstado());
        ////public static readonly Turno turno2 = new Turno(2, date1, "Martes", date2, date3, agregarCambioEstado());
        ////public static readonly Turno turno3 = new Turno(3, date1, "Miercoles", date2, date3, agregarCambioEstado());
        ////public static readonly Turno turno4 = new Turno(4, date1, "Viernes", date2, date3, agregarCambioEstado());

        ////public static readonly PersonalCientifico pc2 = new PersonalCientifico(121, "Mush", "Lopez", 14785236, "usuario2@facultad.com", "usuario2@gmail.com", 351688695, usuario2);

        ////public static readonly RecursoTecnologico rt1 = new RecursoTecnologico(1, date1, "imagen", 10, 20, 5, agregarTurnos(), trt1, modelo1, agregarCamEstado());
        ////public static readonly RecursoTecnologico rt2 = new RecursoTecnologico(2, date1, "imagen", 10, 20, 5, agregarTurnos(), trt2, modelo2, agregarCamEstado());
        ////public static readonly RecursoTecnologico rt3 = new RecursoTecnologico(3, date1, "imagen", 10, 20, 5, agregarTurnos(), trt3, modelo3, agregarCamEstado());
        ////public static readonly RecursoTecnologico rt4 = new RecursoTecnologico(4, date1, "imagen", 10, 20, 5, agregarTurnos(), trt1, modelo1, agregarCamEstado());
        ////public static readonly RecursoTecnologico rt5 = new RecursoTecnologico(5, date1, "imagen", 10, 20, 5, agregarTurnos(), trt2, modelo2, agregarCamEstado());

        ////public static readonly Modelo modelo1 = /*new Modelo(1, "Modelo 1")*/;
        ////public static readonly Modelo modelo2 = new Modelo(2, "Modelo 2");
        ////public static readonly Modelo modelo3 = new Modelo(3, "Modelo 3");
        ////public static readonly Modelo modelo4 = new Modelo(4, "Modelo 4");
        ////public static readonly Modelo modelo5 = new Modelo(5, "Modelo 5");

        ////public static readonly AsignaciónResponsableTecnicoRT asigRespTecn1 = new AsignaciónResponsableTecnicoRT(date1, date1, agregarRT(), pc);
        ////public static readonly AsignaciónResponsableTecnicoRT asigRespTecn2 = new AsignaciónResponsableTecnicoRT(date1, date2, agregarRT(), pc);
        ////public static readonly AsignaciónResponsableTecnicoRT asigRespTecn3 = new AsignaciónResponsableTecnicoRT(date1, date2, agregarRT(), pc2);
        ////public static readonly AsignaciónResponsableTecnicoRT asigRespTecn4 = new AsignaciónResponsableTecnicoRT(date1, date2, agregarRT(), pc2);

        //public static List<Estado> conocerEstados()
        //{
        //    List<Estado> list = new List<Estado>();
        //    list.Add(new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false));
        //    list.Add(new Estado(2, "Cancelable", "Descripcion", "Turno", false, true));
        //    list.Add(new Estado(3, "Reservado", "Descripcion", "Turno", true, false));
        //    list.Add(new Estado(4, "PendienteConfirmacionReserva", "Descripcion", "Turno", false, false));
        //    list.Add(new Estado(5, "CanceladoMantenimientoCorrectivo", "Descripcion", "Turno", false, false));
        //    list.Add(new Estado(6, "EnMantenimientoCorrectivo", "Descripcion", "Recurso Tecnologico", false, false));

        //    return list;
        //}   
        //public static readonly CambioEstadoRT cambEstRT1 = new CambioEstadoRT(date1, date1, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false));
        //public static readonly CambioEstadoRT cambEstRT2 = new CambioEstadoRT(date2, date2, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false));
        //public static readonly CambioEstadoRT cambEstRT3 = new CambioEstadoRT(date3, date3, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false));
        //public static readonly CambioEstadoRT cambEstRT4 = new CambioEstadoRT(date4, date4, new Estado(1, "Disponible", "Descripcion", "Recurso Tecnologico", false, false));
        //public static readonly CambioEstadoRT cambEstRT5 = new CambioEstadoRT(date1, date4, new Estado(6, "EnMantenimientoCorrectivo", "Descripcion", "Recurso Tecnologico", false, false));

        //public static readonly CambioEstadoTurno cambEstTurno1 = new CambioEstadoTurno(date1, date1, new Estado(2, "Cancelable", "Descripcion", "Turno", false, true));
        //public static readonly CambioEstadoTurno cambEstTurno2 = new CambioEstadoTurno(date2, date2, new Estado(3, "Reservado", "Descripcion", "Turno", true, false));
        //public static readonly CambioEstadoTurno cambEstTurno3 = new CambioEstadoTurno(date3, date3, new Estado(4, "PendienteConfirmacionReserva", "Descripcion", "Turno", false, false));
        //public static readonly CambioEstadoTurno cambEstTurno4 = new CambioEstadoTurno(date3, date3, new Estado(5, "CanceladoMantenimientoCorrectivo", "Descripcion", "Turno", false, false));
    }
}

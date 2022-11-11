using PPAI.Entidades;
using PPAI.Servicio_Acceso_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Servicios
{
    class RecursoTecnologicoServicio
    {

        private ModeloServicio modeloServicioBD = new ModeloServicio();
        private TipoRecursoTecnologicoServicio tipoRTServicioBD = new TipoRecursoTecnologicoServicio();
        private EstadoServicio estadoServicioBD = new EstadoServicio();
        private CambioEstadoRTServicio cambioEstadoRTServicioBD = new CambioEstadoRTServicio();

        public List<RecursoTecnologico> GetRecursos()
        {
            var sql = $"SELECT * FROM RecursoTecnologico";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var recursos = new List<RecursoTecnologico>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var recursoTecnologico = new RecursoTecnologico();
                recursoTecnologico.NumeroRT = Convert.ToInt32(fila["numeroRT"].ToString());
                recursoTecnologico.Duracion = Convert.ToInt32(fila["duracion"].ToString());
                recursoTecnologico.FechaAlta = Convert.ToDateTime(fila["fechaAlta"].ToString());
                recursoTecnologico.FraccionHorarioTurno = Convert.ToInt32(fila["fraccionHorarioTurno"].ToString());
                recursoTecnologico.Periodicidad = Convert.ToInt32(fila["periocidadMantenimientoPreventivo"].ToString());

                int idModelo = Convert.ToInt32(fila["id_modelo"].ToString());
                recursoTecnologico.Modelo = modeloServicioBD.getModelo(idModelo);

                int idTipo = Convert.ToInt32(fila["id_tipoRT"].ToString());
                recursoTecnologico.TipoRecurso = tipoRTServicioBD.getTipoRT(idTipo);

                int idEstado = Convert.ToInt32(fila["id_estado"].ToString());
                recursoTecnologico.Estado = estadoServicioBD.getEstado(idEstado);

                recursoTecnologico.CambioEstado = cambioEstadoRTServicioBD.GetCambiosEstados(recursoTecnologico.NumeroRT);

                recursos.Add(recursoTecnologico);
            }

            return recursos;
        }

        public List<RecursoTecnologico> GetRecursosDisponibles()
        {
            var sql = $"SELECT * FROM RecursoTecnologico WHERE id_estado = 1";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var recursos = new List<RecursoTecnologico>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var recursoTecnologico = new RecursoTecnologico();
                recursoTecnologico.NumeroRT = Convert.ToInt32(fila["numeroRT"].ToString());
                recursoTecnologico.Duracion = Convert.ToInt32(fila["duracion"].ToString());
                recursoTecnologico.FechaAlta = Convert.ToDateTime(fila["fechaAlta"].ToString());
                recursoTecnologico.FraccionHorarioTurno = Convert.ToInt32(fila["fraccionHorarioTurno"].ToString());
                recursoTecnologico.Periodicidad = Convert.ToInt32(fila["periocidadMantenimientoPreventivo"].ToString());

                int idModelo = Convert.ToInt32(fila["id_modelo"].ToString());
                recursoTecnologico.Modelo = modeloServicioBD.getModelo(idModelo);

                int idTipo = Convert.ToInt32(fila["id_tipoRT"].ToString());
                recursoTecnologico.TipoRecurso = tipoRTServicioBD.getTipoRT(idTipo);

                int idEstado = Convert.ToInt32(fila["id_estado"].ToString());
                recursoTecnologico.Estado = estadoServicioBD.getEstado(idEstado);

                recursoTecnologico.CambioEstado = cambioEstadoRTServicioBD.GetCambiosEstados(recursoTecnologico.NumeroRT);

                recursos.Add(recursoTecnologico);
            }

            return recursos;
        }

        public List<RecursoTecnologico> GetRecursosPorAsignacion(int idAsignacion)
        {
            var sql = $"SELECT * FROM RecursoTecnologico WHERE id_asignacion = {idAsignacion}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var recursos = new List<RecursoTecnologico>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var recursoTecnologico = new RecursoTecnologico();
                recursoTecnologico.NumeroRT = Convert.ToInt32(fila["numeroRT"].ToString());
                recursoTecnologico.Duracion = Convert.ToInt32(fila["duracion"].ToString());
                recursoTecnologico.FechaAlta = Convert.ToDateTime(fila["fechaAlta"].ToString());
                recursoTecnologico.FraccionHorarioTurno = Convert.ToInt32(fila["fraccionHorarioTurno"].ToString());
                recursoTecnologico.Periodicidad = Convert.ToInt32(fila["periocidadMantenimientoPreventivo"].ToString());

                int idModelo = Convert.ToInt32(fila["id_modelo"].ToString());
                recursoTecnologico.Modelo = modeloServicioBD.getModelo(idModelo);

                int idTipo = Convert.ToInt32(fila["id_tipoRT"].ToString());
                recursoTecnologico.TipoRecurso = tipoRTServicioBD.getTipoRT(idTipo);

                int idEstado = Convert.ToInt32(fila["id_estado"].ToString());
                recursoTecnologico.Estado = estadoServicioBD.getEstado(idEstado);

                recursoTecnologico.CambioEstado = cambioEstadoRTServicioBD.GetCambiosEstados(recursoTecnologico.NumeroRT);

                recursos.Add(recursoTecnologico);
            }

            return recursos;
        }

        public RecursoTecnologico obtenerRecursoTecnologico(int idRT)
        {
            var sql = $"SELECT * FROM RecursoTecnologico WHERE numeroRT = {idRT}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var recursoTecnologico = new RecursoTecnologico();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                recursoTecnologico.NumeroRT = Convert.ToInt32(fila["numeroRT"].ToString());
                recursoTecnologico.Duracion = Convert.ToInt32(fila["duracion"].ToString());
                recursoTecnologico.FechaAlta = Convert.ToDateTime(fila["fechaAlta"].ToString());
                recursoTecnologico.FraccionHorarioTurno = Convert.ToInt32(fila["fraccionHorarioTurno"].ToString());
                recursoTecnologico.Periodicidad = Convert.ToInt32(fila["periocidadMantenimientoPreventivo"].ToString());

                int idModelo = Convert.ToInt32(fila["id_modelo"].ToString());
                recursoTecnologico.Modelo = modeloServicioBD.getModelo(idModelo);

                int idTipo = Convert.ToInt32(fila["id_tipoRT"].ToString());
                recursoTecnologico.TipoRecurso = tipoRTServicioBD.getTipoRT(idTipo);

                int idEstado = Convert.ToInt32(fila["id_estado"].ToString());
                recursoTecnologico.Estado = estadoServicioBD.getEstado(idEstado);

                recursoTecnologico.CambioEstado = cambioEstadoRTServicioBD.GetCambiosEstados(recursoTecnologico.NumeroRT);
            }

            return recursoTecnologico;
        }

        public void actualizarEstado(int numRT)
        {
            var sql = $"UPDATE RecursoTecnologico SET id_estado = 6 WHERE numeroRT = {numRT}";
            DBHelper.GetDBHelper().ConsultaSQL(sql);
        }
    }
}

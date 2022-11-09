using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Mantenimiento
    {
        private DateTime? fechaFin;
        private DateTime? fechaInicio;
        private DateTime? fechaInicioPrevista;
        private string motivoMantenimiento;

        public DateTime? FechaFin
        {
            get => fechaFin;
            set => fechaFin = value;
        }

        public DateTime? FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public DateTime? FechaInicioPrevista { get => fechaInicioPrevista; set => fechaInicioPrevista = value; }

        public string MotivoMantenimiento { get => motivoMantenimiento; set => motivoMantenimiento = value;
        }

        public Mantenimiento()
        {

        }

        public Mantenimiento(DateTime? fechaFin, DateTime? fechaInicio, DateTime? fechaInicioPrevista, string motivoMantenimiento)
        {
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
            this.fechaInicioPrevista = fechaInicioPrevista;
            this.motivoMantenimiento = motivoMantenimiento;
        }
    }
}

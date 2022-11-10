﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades.Estados
{
    class DisponibleRT : Estado
    {
        private string nombre = "DisponibleRT";
        private string ambito = "rt";

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }

        override
        public bool esDisponible()
        {
            return true;
        }
    }
}

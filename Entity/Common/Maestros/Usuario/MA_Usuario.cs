﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Maestros.Usuario
{
    public class MA_Usuario
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public string cod_persona { get; set; }
        public string cod_perfil { get; set; }
        public string estado { get; set; }
        public string creado_por { get; set; }
        public string fecha_creacion { get; set; }
        public string modificado_por { get; set; }
        public string fecha_modificacion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Maestros.Usuario
{
    public class MA_Persona
    {
        public string codigo { get; set; }
        public string cod_tipdoc { get; set; }
        public string num_documento { get; set; }
        public string pri_nombre { get; set; }
        public string seg_nombre { get; set; }
        public string pri_apellido { get; set; }
        public string seg_apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string cod_ubigeo { get; set; }
        public string estado { get; set; }
        public string creado_por { get; set; }
        public string fecha_creacion { get; set; }
        public string modificado_por { get; set; }
        public string fecha_modificacion { get; set; }
    }
}

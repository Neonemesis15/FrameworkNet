using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Maestros.Item
{
    public class MA_Item
    {
        public string cod_padre { get; set; }
        public string codigo { get; set; }
        public string cod_interno { get; set; }
        public string nombre { get; set; }
        public string cod_tip_item { get; set; }
        public string estado { get; set; }
        public string creado_por { get; set; }
        public string fecha_creacion { get; set; }
        public string modificado_por { get; set; }
        public string fecha_modificacion { get; set; }
    }
}

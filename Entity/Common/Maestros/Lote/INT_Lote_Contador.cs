using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Business.Common.Maestros.Lote
{
    public class INT_Lote_Contador
    {
        public string codigo { get; set; }
        public string idelote { get; set; }
        public string orden { get; set; }
        public string cod_proceso { get; set; }
        public string reg_total { get; set; }
        public string reg_error { get; set; }
        public string reg_ok { get; set; }
        public string estado { get; set; }
        public string fecha_incio { get; set; }
        public string fecha_fin { get; set; }
    }
}

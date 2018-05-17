using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Maestros.Lote
{
    public class INT_Lote
    {
        public string codigo { get; set; }
        public string nombre_archivo { get; set; }
        public string estado { get; set; }
        public string fecha_creacion { get; set; }
        public string creado_por { get; set; }
        public string fecha_modificacion { get; set; }
        public string modificado_por { get; set; }
        public List<INT_Lote_Det> list_LoteDet{ get; set; }
    }
}

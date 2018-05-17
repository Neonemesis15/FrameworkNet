using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class E_TipoProfiles
    {
        public string TipPerfil_id { get; set; }
        public string TipPerfil_Descripcion { get; set; }
        public bool Status { get; set; }
        public string CreateBy { get; set; }
        public string DateBy { get; set; }
        public string ModiBy { get; set; }
        public string DateModiBy { get; set; }
    }
}

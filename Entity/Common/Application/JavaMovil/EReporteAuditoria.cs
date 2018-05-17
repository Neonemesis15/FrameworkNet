using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EReporteAuditoria
    {
        [Newtonsoft.Json.JsonProperty("c")]
        public string Codigo { get; set; }

        [Newtonsoft.Json.JsonProperty("d")]
        public string Descripcion { get; set; }

        [Newtonsoft.Json.JsonProperty("t")]
        public string TipoReporte { get; set; }
    }
}

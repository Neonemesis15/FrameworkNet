using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Codigo_ITT_Detalle
    {
        [JsonIgnore()]
        public int idRegistro { get; set; }

        [JsonProperty("a")]
        public string id { get; set; }

        [JsonProperty("b")]
        public string distribuidora { get; set; }

        [JsonProperty("c")]
        public string codigo { get; set; }

    }
}

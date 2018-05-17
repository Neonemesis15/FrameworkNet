using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string Reporte_Alias { get; set; }

        [JsonProperty("c")]
        public string CodSubReporte { get; set; }

        [JsonProperty("d")]
        public string SubReporteAlias { get; set; }

        //[JsonIgnore()]
        [JsonProperty("e")]
        public string Orden { get; set; }
    }
}

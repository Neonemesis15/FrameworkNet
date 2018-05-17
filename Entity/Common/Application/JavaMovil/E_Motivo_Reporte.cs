using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Motivo_Reporte
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodMotivo { get; set; }

        [JsonProperty("c")]
        public string NombreMotivo { get; set; }
    }
}

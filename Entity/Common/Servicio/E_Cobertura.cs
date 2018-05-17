using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Cobertura
    {
        [JsonProperty("a")]
        public int totalPDV { get; set; }

        [JsonProperty("b")]
        public int totalPDVVisitados { get; set; }

        [JsonProperty("c")]
        public double alcance { get; set; }
    }
}
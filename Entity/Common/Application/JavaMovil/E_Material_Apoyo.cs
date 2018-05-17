using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Material_Apoyo
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodTipo { get; set; }

        [JsonProperty("c")]
        public string CodMaterial { get; set; }

        [JsonProperty("d")]
        public string MatDescripcion { get; set; }

        [JsonProperty("e")]
        public string Propio { get; set; }
    }
}

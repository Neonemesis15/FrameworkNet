using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Familia
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodFamilia { get; set; }

        [JsonProperty("c")]
        public string FamiliaNombre { get; set; }

        [JsonProperty("d")]
        public string CodMarca { get; set; }

        [JsonProperty("e")]
        public string CodCategoria { get; set; }

        [JsonProperty("f")]
        public string CodSubCategoria { get; set; }

        [JsonProperty("g")]
        public string CodSubMarca { get; set; }

        [JsonProperty("h")]
        public string CodPresentacion { get; set; }
    }
}

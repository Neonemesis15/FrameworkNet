using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_SubFamilia
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodSubFamilia { get; set; }

        [JsonProperty("c")]
        public string SubFamiliaNombre { get; set; }

        [JsonProperty("d")]
        public string CodCategoria { get; set; }

        [JsonProperty("e")]
        public string CodMarca { get; set; }

        [JsonProperty("f")]
        public string CodFamilia { get; set; }

        [JsonProperty("g")]
        public string CodSubCategoria { get; set; }

        [JsonProperty("h")]
        public string CodSubMarca { get; set; }

        [JsonProperty("i")]
        public string CodPresentacion { get; set; }
    }
}

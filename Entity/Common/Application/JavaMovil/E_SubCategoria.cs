using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_SubCategoria
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }
        
        [JsonProperty("b")]
        public string CodCategoria { get; set; }

        [JsonProperty("c")]
        public string CodSubCategoria { get; set; }

        [JsonProperty("d")]
        public string SubCategoriaNombre { get; set; }
    }
}

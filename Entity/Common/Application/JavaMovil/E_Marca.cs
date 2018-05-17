using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Marca
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodMarca { get; set; }

        [JsonProperty("c")]
        public string MarcaNombre { get; set; }

        [JsonProperty("d")]
        public string CodCategoria { get; set; }
        
        [JsonProperty("e")]
        public int MarcaPropia { get; set; }

        [JsonProperty("f")]
        public string CodSubCategoria { get; set; }
    }
}
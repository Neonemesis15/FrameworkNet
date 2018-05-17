using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Categoria
    {
        [JsonProperty("a")]
        public string IdReporte { get; set; }

        [JsonProperty("b")]
        public string IdCategoria { get; set; }

        [JsonProperty("c")]
        public string CategoriaNombre { get; set; }

    }
}

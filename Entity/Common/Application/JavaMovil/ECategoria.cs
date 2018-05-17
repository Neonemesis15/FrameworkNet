using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class ECategoria
    {
        [JsonProperty("i")]
        public string IdReporte { get; set; }

        [JsonProperty("t")]
        public string IdCategoria { get; set; }

        [JsonProperty("n")]
        public string CategoriaNombre { get; set; }

        [JsonProperty("l")]
        public string LongitudCadena { get; set; }
    }
}
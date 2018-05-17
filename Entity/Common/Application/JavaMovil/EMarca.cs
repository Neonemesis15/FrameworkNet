using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EMarca
    {
        [JsonProperty("i")]
        public string IdReporte { get; set; }

        [JsonProperty("m")]
        public string IdMarca { get; set; }

        [JsonProperty("n")]
        public string Nombre { get; set; }

        [JsonProperty("c")]
        public string IdCategoria { get; set; }

        [JsonProperty("l")]
        public string LongitudCad { get; set; }

        [JsonProperty("p")]
        public string MarcaPropia { get; set; }
    }
}
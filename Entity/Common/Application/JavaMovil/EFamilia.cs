using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EFamilia
    {
        [JsonProperty("r")]
        public string IdReporte { get; set; }

        [JsonProperty("c")]
        public string Reporte { get; set; }

        [JsonProperty("d")]
        public string Descripcion { get; set; }

        [JsonProperty("m")]
        public string IdMarca { get; set; }

        [JsonProperty("g")]
        public string IdCategoria { get; set; }
    }
}
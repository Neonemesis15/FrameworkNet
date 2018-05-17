using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EReporte
    {
        [JsonProperty("i")]
        public string IdOpReporte { get; set; }

        [JsonProperty("n")]
        public string IdCanal { get; set; }

        [JsonProperty("r")]
        public string IdReporte { get; set; }

        [JsonProperty("t")]
        public string IdTipoReporte { get; set; }

        [JsonProperty("c")]
        public int VistaCategoria { get; set; }

        [JsonProperty("m")]
        public int VistaMarca { get; set; }

        [JsonProperty("s")]
        public int VistaSubMarca { get; set; }

        [JsonProperty("f")]
        public int VistaFamilia { get; set; }

        [JsonProperty("p")]
        public int VistaProducto { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PuntoVentaCluster
    {
        [JsonProperty("a")]
        public string codPuntoVenta { get; set; }

        [JsonProperty("b")]
        public string nombrePuntoVenta { get; set; }

        [JsonProperty("c")]
        public string latitud { get; set; }

        [JsonProperty("d")]
        public string longitud { get; set; }

        [JsonProperty("e")]
        public string cantidad { get; set; }

        [JsonProperty("f")]
        public string total{ get; set; }

        [JsonProperty("g")]
        public string presencia { get; set; }

        [JsonProperty("h")]
        public string color { get; set; }

        [JsonProperty("i")]
        public string cluster { get; set; }

        [JsonProperty("j")]
        public string cobertura { get; set; } 
    }
}

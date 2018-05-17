using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PuntoVentaMapa
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
        public string color { get; set; }

        [JsonProperty("f")]
        public string segmento { get; set; }
    }
}

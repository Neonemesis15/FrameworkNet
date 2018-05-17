using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_VentasZonaDistrito
    {
        [JsonProperty("a")]
        public string idCategoria { get; set; }

        [JsonProperty("b")]
        public string nombreCategoria { get; set; }

        [JsonProperty("c")]
        public string idDistribuidora { get; set; }

        [JsonProperty("d")]
        public string nombreDistribuidora { get; set; }

        [JsonProperty("e")]
        public double venta { get; set; }
    }
}

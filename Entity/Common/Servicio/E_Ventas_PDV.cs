using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Ventas_PDV
    {
        [JsonProperty("a")]
        public string codSKU { get; set; }

        [JsonProperty("b")]
        public string nombreSKU { get; set; }

        [JsonProperty("c")]
        public double ventas { get; set; }

        [JsonProperty("d")]
        public string cantidad { get; set; }

        [JsonProperty("e")]
        public double precioUnit { get; set; }
    }
}

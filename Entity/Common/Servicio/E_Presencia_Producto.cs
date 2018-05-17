using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Presencia_Producto
    {
        [JsonProperty("a")]
        public string codigoProducto { get; set; }

        [JsonProperty("b")]
        public string nombreProducto { get; set; }

        [JsonProperty("c")]
        public string codigoCategoria { get; set; }

        [JsonProperty("d")]
        public string nombreCategoria { get; set; }

        [JsonProperty("e")]
        public double valor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Presencia_PDV
    {
        [JsonProperty("a")]
        public string idTipo { get; set; }

        [JsonProperty("b")]
        public string tipo { get; set; }

        [JsonProperty("c")]
        public string codProducto { get; set; }

        [JsonProperty("d")]
        public string nombreProducto { get; set; }

        [JsonProperty("e")]
        public string codCliente { get; set; }

        [JsonProperty("f")]
        public int presencia { get; set; }
    }
}
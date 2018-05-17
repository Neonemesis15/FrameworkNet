using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_ElemVisibilidad_PDV
    {
        [JsonProperty("a")]
        public string idTipo { get; set; }

        [JsonProperty("b")]
        public string tipo { get; set; }

        [JsonProperty("c")]
        public string codElemento { get; set; }

        [JsonProperty("d")]
        public string nombreElemento { get; set; }

        [JsonProperty("e")]
        public string codCliente { get; set; }

        [JsonProperty("f")]
        public string nombreCliente { get; set; }

        [JsonProperty("g")]
        public int cantidad { get; set; }
    }
}

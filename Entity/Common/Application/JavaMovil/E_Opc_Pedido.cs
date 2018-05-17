using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Opc_Pedido
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodOpcPedido { get; set; }

        [JsonProperty("c")]
        public string NombreOpcPedido { get; set; }
    }
}

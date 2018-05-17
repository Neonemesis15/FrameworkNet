using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Canal_x_Cliente
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }
        
        [JsonProperty("b")]
        public string descCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }
    }
}

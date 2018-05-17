using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Status_EQF
    {
        [JsonProperty("a")]
        public string codigo { get; set; }

        [JsonProperty("b")]
        public string nombre { get; set; }

        [JsonProperty("c")]
        public int cantidad { get; set; }
    }
}
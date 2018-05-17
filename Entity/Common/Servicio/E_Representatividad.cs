using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Representatividad
    {
        [JsonProperty("a")]
        public int total { get; set; }

        [JsonProperty("b")]
        public int cantidad { get; set; }

        [JsonProperty("c")]
        public int zona { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Foto_PDV
    {
        [JsonProperty("a")]
        public string interiorAntes { get; set; }

        [JsonProperty("b")]
        public string interiorDespues { get; set; }

        [JsonProperty("c")]
        public string exteriorAntes { get; set; }

        [JsonProperty("d")]
        public string exteriorDespues { get; set; }
    }
}

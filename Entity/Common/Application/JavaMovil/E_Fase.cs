using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Fase
    {
        [JsonProperty("a")]
        public string CodFase { get; set; }

        [JsonProperty("b")]
        public string NombreFase { get; set; }

        [JsonProperty("c")]
        public int Orden { get; set; }
    }
}

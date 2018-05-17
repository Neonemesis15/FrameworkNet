using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.EAPro
{
    public class EAPRO_Usuario
    {
        [JsonProperty("a")]
        public string codigo { get; set; }

        [JsonProperty("b")]
        public string nombre { get; set; }

        [JsonProperty("c")]
        public string codigoCargo { get; set; }

        [JsonProperty("d")]
        public string cargo { get; set; }

        [JsonProperty("e")]
        public string perfil { get; set; }

        [JsonProperty("f")]
        public string email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PresenciaZonaDistrito
    {
        [JsonProperty("a")]
        public string id_tipo { get; set; }

        [JsonProperty("b")]
        public string tipo { get; set; }

        [JsonProperty("c")]
        public string id_elemento { get; set; }

        [JsonProperty("d")]
        public string nombre_elemento { get; set; }

        [JsonProperty("e")]
        public string coverage { get; set; }

        [JsonProperty("f")]
        public string totalcoverage { get; set; }

        [JsonProperty("g")]
        public string rangos { get; set; }

        [JsonProperty("h")]
        public string cobertura { get; set; }

        [JsonProperty("i")]
        public string nombreCliente { get; set; }
    }
}

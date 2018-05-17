using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PresenciaZonaDistritoMap
    {

        [JsonProperty("a")]
        public string id_elemento { get; set; }

        [JsonProperty("b")]
        public string nombre_elemento { get; set; }

        [JsonProperty("c")]
        public string coverage { get; set; }

        [JsonProperty("d")]
        public string totalcoverage { get; set; }

        [JsonProperty("e")]
        public string presencia { get; set; }

        [JsonProperty("f")]
        public string codColor { get; set; }

        [JsonProperty("g")]
        public string cobertura { get; set; }

        [JsonProperty("h")]
        public string cod_cobertura { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_VentasZonaDistrito_Detalle
    {
        [JsonProperty("a")]
        public string[] Header { get; set; }
        [JsonProperty("b")]
        public string[][] Contents { get; set; }
    }

    public class E_VentasZonaDistrito_Detalle_List
    {
        [JsonProperty("a")]
        public string nombreSKU { get; set; }

        [JsonProperty("b")]
        public string valor1 { get; set; }

        [JsonProperty("c")]
        public string valor2 { get; set; }

        [JsonProperty("d")]
        public string valor3 { get; set; }

        [JsonProperty("e")]
        public string valor4 { get; set; }

        [JsonProperty("f")]
        public string valor5 { get; set; }

        [JsonProperty("g")]
        public string valor6 { get; set; }

        [JsonProperty("h")]
        public string valor7 { get; set; }

        [JsonProperty("i")]
        public string valor8 { get; set; }

    }

}

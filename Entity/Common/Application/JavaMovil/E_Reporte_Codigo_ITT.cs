using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Codigo_ITT
    {
        [JsonIgnore()]
        public int idRegistro { get; set; }

        [JsonProperty("a")]
        public string personId { get; set; }

        [JsonProperty("b")]
        public string perfilId { get; set; }

        [JsonProperty("c")]
        public string equipoId { get; set; }

        [JsonProperty("d")]
        public string clienteId { get; set; }

        [JsonProperty("e")]
        public string clientPDV_Code { get; set; }

        [JsonProperty("f")]
        public string fechaReg { get; set; }

        [JsonProperty("g")]
        public string latitud { get; set; }

        [JsonProperty("h")]
        public string longitud { get; set; }

        [JsonProperty("i")]
        public string origen { get; set; }

        [JsonProperty("j")]
        public List<E_Reporte_Codigo_ITT_Detalle> detalle { get; set; }

    }
}

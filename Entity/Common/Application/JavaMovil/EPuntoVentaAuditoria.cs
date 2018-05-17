using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EPuntoVentaAuditoria
    {
        [JsonProperty("i")]
        public string Codigo { get; set; }

        [JsonProperty("r")]
        public string RazonSocial { get; set; }

        [JsonProperty("a")]
        public string Direccion { get; set; }

        [JsonProperty("c")]
        public string NombreCanal { get; set; }

        [JsonProperty("t")]
        public string TipoMercado { get; set; }
    }
}

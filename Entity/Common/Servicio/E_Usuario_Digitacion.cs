using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Usuario_Digitacion
    {
        [JsonProperty("a")]
        public string codigoCliente { get; set; }

        [JsonProperty("b")]
        public string fotoCliente { get; set; }

        [JsonProperty("c")]
        public string nombreCliente { get; set; }

        [JsonProperty("d")]
        public string codigoUsuario { get; set; }

        [JsonProperty("e")]
        public string codigoPerfil { get; set; }

        [JsonProperty("f")]
        public string nombreUsuario { get; set; }

        [JsonProperty("g")]
        public string nombreCompleto { get; set; }
    }
}

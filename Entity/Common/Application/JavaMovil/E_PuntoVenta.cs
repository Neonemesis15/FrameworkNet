using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_PuntoVenta
    {
        [JsonProperty("a")]
        public string CodigoPDV { get; set; }

        [JsonProperty("b")]
        public string RazonSocial { get; set; }

        [JsonProperty("c")]
        public string Direccion { get; set; }

        [JsonProperty("d")]
        public string CodigoCadena { get; set; }

        [JsonProperty("e")]
        public string NombreCadena { get; set; }

        [JsonProperty("f")]
        public string CodigoCanal { get; set; }

        [JsonProperty("g")]
        public string NombreCanal { get; set; }

        [JsonProperty("h")]
        public string TipoMercado { get; set; }

        //[JsonProperty("i")]
        [JsonProperty("j")]
        public string latitud { get; set; }

        //[JsonProperty("j")]
        [JsonProperty("i")]
        public string longitud { get; set; }

        [JsonProperty("k")]
        public string Fase { get; set; }
    }
}

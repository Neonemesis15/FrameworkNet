using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Datos_Presencia
    {
        [JsonProperty("a")]
        public string CodPtoVenta { get; set; }

        [JsonProperty("b")]
        public string CodCategoria { get; set; }

        [JsonProperty("c")]
        public string CodMarca { get; set; }

        [JsonProperty("d")]
        public string CodOpcion { get; set; }

        [JsonProperty("e")]
        public string CodElemento { get; set; }

        [JsonProperty("f")]
        public string CodValor { get; set; }
    }
}

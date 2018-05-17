using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Servicio
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodServicio { get; set; }

        [JsonProperty("c")]
        public string ServicioNombre { get; set; }

        [JsonProperty("d")]
        public string CodCategoria { get; set; }

        [JsonProperty("e")]
        public string CodMarca  { get; set; }
    }
}

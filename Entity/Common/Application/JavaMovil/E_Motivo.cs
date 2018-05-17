using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Motivo
    {
        [JsonProperty("a")]
        public string Codigo { get; set; }

        [JsonProperty("b")]
        public string CodigoEstado { get; set; }

        [JsonProperty("c")]
        public string Descripcion { get; set; }
    }
}

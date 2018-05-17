using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EMotivo
    {
        [JsonProperty("c")]
        public string Codigo { get; set; }

        [JsonProperty("e")]
        public string CodigoEstado { get; set; }

        [JsonProperty("d")]
        public string Descripcion { get; set; }
    }
}

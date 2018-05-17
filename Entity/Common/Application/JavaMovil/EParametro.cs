using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EParametro
    {
        [JsonProperty("t")]
        public int CodigoTabla { get; set; }

        [JsonProperty("c")]
        public string Codigo { get; set; }

        [JsonProperty("d")]
        public string Descripcion { get; set; }

        [JsonProperty("v")]
        public string Valor { get; set; }
    }
}
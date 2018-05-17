using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Credito
    {
        [JsonProperty("a")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("b")]
        public string Cod_Credito { get; set; }
        [JsonProperty("c")]
        public string Cre_Nombre { get; set; }
    }
}

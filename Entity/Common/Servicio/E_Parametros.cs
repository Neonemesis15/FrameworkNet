using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Parametros
    {
        [JsonProperty("a")]
        public string Tipo { get; set; }
        [JsonProperty("b")]
        public string Descripcion { get; set; }
        [JsonProperty("c")]
        public string Valor { get; set; } 
    }
}

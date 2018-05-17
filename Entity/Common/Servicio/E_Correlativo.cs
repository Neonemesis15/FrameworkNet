using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Correlativo
    {
        [JsonProperty("a")]
        public string Nro_Doc { get; set; }
        [JsonProperty("b")]
        public string Tipo_Doc { get; set; }
    }
}

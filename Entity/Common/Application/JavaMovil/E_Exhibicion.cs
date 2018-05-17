using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Exhibicion
    {
        [JsonProperty("a")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("b")]
        public string Cod_Exhibicion { get; set; }
        [JsonProperty("c")]
        public string Exh_Descripcion { get; set; }
    }
}

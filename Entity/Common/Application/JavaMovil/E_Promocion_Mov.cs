using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Promocion_Mov
    {
        [JsonProperty("a")]
        public string CodPromocion { get; set; }

        [JsonProperty("b")]
        public string Descripcion { get; set; }

        [JsonProperty("c")]
        public string CodReporte { get; set; }

        // 
        //[JsonIgnore()]
        [JsonProperty("d")]
        public string CodCompania { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Distribuidora_PtoVenta
    {
        [JsonProperty("a")]
        public string CodDistribuidora { get; set; }
    
        [JsonProperty("b")]
        public string CodPtoVenta { get; set; }

    }
}

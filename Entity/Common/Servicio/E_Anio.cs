using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Anio
    {
        [JsonProperty("a")]
        public int anio { get; set; } 
    }
}

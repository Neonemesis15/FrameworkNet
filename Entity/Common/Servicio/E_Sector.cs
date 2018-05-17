using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Sector
    {
        [JsonProperty("a")]
        public string codSector { get; set; }

        [JsonProperty("b")]
        public string nombreSector { get; set; }
    }
}

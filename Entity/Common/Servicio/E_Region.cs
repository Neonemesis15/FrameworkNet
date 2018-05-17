using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace Lucky.Entity.Common.Servicio
{
    public class E_Region
    {
        [JsonProperty("a")]
        public string idRegion { get; set; }

        [JsonProperty("b")]
        public string nameRegion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.EAPro
{
    public class E_CentroCosto
    {
        [JsonProperty("a")]
        public string codigo { get; set; }

        [JsonProperty("b")]
        public string descripcion { get; set; }

        [JsonProperty("c")]
        public string empresa { get; set; }
    }
}

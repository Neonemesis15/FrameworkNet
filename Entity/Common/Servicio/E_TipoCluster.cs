using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_TipoCluster
    {
        [JsonProperty("a")]
        public string codigo { get; set; }

        [JsonProperty("b")]
        public string descripcion { get; set; }
    }
}

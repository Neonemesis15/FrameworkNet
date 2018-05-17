using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_SubCategoria
    {
        [JsonProperty("a")]
        public string Cod_SubCategoria { get; set; }

        [JsonProperty("b")]
        public string Nombre_SubCategoria { get; set; }
    }
}
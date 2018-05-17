using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PuntodeVentaPlanning
    {
        [JsonProperty("a")]
        public string codPdv { get; set; }
        [JsonProperty("b")]
        public string nombrePdv { get; set; }
        [JsonProperty("c")]
        public string direccionPdv { get; set; }
        [JsonProperty("d")]
        public string regionPdv { get; set; }
        [JsonProperty("e")]
        public string zonapdv { get; set; }
    }
}

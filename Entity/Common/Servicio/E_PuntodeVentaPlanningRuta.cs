using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PuntodeVentaPlanningRuta
    {
        [JsonProperty("a")]
        public string id_POSPlanningOpe { get; set; }
        [JsonProperty("b")]
        public string codPdv { get; set; }
        [JsonProperty("c")]
        public string nombrePdv { get; set; }
        [JsonProperty("d")]
        public string direccionPdv { get; set; }
        [JsonProperty("e")]
        public string regionPdv { get; set; }
        [JsonProperty("f")]
        public string zonapdv { get; set; }
        [JsonProperty("g")]
        public string fecha_Inicio { get; set; }
        [JsonProperty("h")]
        public string fecha_Fin { get; set;}
        [JsonProperty("i")]
        public string latitud { get; set; }
        [JsonProperty("j")]
        public string longitud { get; set; }
        [JsonProperty("k")]
        public string estado { get; set; }
    }
}

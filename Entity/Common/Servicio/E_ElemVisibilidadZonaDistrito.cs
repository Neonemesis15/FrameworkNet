using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_ElemVisibilidadZonaDistrito
    {
        [JsonProperty("a")]
        public string idElemento { get; set; }

        [JsonProperty("b")]
        public string nombreElemento { get; set; }

        [JsonProperty("c")]
        public string nombrePropio { get; set; }

        [JsonProperty("d")]
        public string cantidadPropio { get; set; }
        
        [JsonProperty("e")]
        public string nombreCompetencia { get; set; }
        
        [JsonProperty("f")]
        public string cantidadCompetencia { get; set; }
    }
}
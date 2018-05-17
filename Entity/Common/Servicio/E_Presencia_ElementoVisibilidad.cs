using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Presencia_ElementoVisibilidad
    {
        [JsonProperty("a")]
        public string codigoElemento { get; set; }

        [JsonProperty("b")]
        public string nombreElemento { get; set; }

        [JsonProperty("c")]
        public double porcentaje { get; set; }

        [JsonProperty("d")]
        public string tipo { get; set; }
    }
}
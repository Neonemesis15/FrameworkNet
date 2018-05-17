using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Reporte_Data_Validada
    {
        [JsonProperty("a")]
        public int CantidadValidado { get; set; }

        [JsonProperty("b")]
        public int CantidadInvalidado { get; set; }

        [JsonProperty("c")]
        public string PorcentajeValidado { get; set; }

        [JsonProperty("d")]
        public string PorcentajeInvalidado { get; set; }
    }
}

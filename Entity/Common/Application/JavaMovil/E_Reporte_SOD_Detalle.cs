using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_SOD_Detalle
    {
        [JsonIgnore()]
        public string Id_Reg_SOD { get; set; }
        [JsonProperty("a")]
        public string Id_Brand { get; set; }
        [JsonProperty("b")]
        public string Exhib_Primaria { get; set; }
        [JsonProperty("c")]
        public string Exhib_Secundaria { get; set; }
        [JsonProperty("d")]
        public string Motivo_Obs { get; set; }

    }
}

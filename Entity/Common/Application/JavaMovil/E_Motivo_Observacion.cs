using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Motivo_Observacion
    {
        [JsonProperty("a")]
        public string Cod_MObs { get; set; }
        [JsonProperty("b")]
        public string MObs_Descripcion { get; set; }
        [JsonProperty("c")]
        public string Cod_Reporte { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Ubicacion
    {
        [JsonProperty("a")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("b")]
        public string Cod_SubReporte { get; set; }
        [JsonProperty("c")]
        public string Cod_Ubicacion { get; set; }
        [JsonProperty("d")]
        public string Ubi_Descripcion { get; set; }
    }
}

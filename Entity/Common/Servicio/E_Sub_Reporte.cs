using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Sub_Reporte
    {
        [JsonProperty("a")]
        public string Cod_SubReporte { get; set; }

        [JsonProperty("b")]
        public string Nombre_SubReporte { get; set; }
    }
}

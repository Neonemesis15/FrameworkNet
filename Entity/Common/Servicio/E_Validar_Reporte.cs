using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Validar_Reporte
    {
        [JsonProperty("a")]
        public string codReporte { get; set; }
    }
}

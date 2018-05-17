using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Resumen
    {
        [JsonProperty("a")]
        public string NombreResumen { get; set; }
        [JsonProperty("b")]
        public string Cantidad { get; set; }
    }
}

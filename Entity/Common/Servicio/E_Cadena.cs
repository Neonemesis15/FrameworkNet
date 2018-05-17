using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Cadena
    {
        [JsonProperty("a")]
        public int Cod_Cadena { get; set; }

        [JsonProperty("b")]
        public string Nombre_Cadena { get; set; }
    }
}

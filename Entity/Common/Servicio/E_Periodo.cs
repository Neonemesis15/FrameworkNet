using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Periodo
    {
        [JsonProperty("a")]
        public int Cod_Periodo { get; set; }

        [JsonProperty("b")]
        public string Descripcion { get; set; }
    }
}

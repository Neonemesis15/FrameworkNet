using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Distrito
    {
        [JsonProperty("a")]
        public string CodDistrito { get; set; }

        [JsonProperty("b")]
        public string NombreDistrito { get; set; }
    }
}

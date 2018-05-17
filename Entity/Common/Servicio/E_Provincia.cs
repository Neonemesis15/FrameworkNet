using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Provincia
    {
        [JsonProperty("a")]
        public string CodProvincia { get; set; }

        [JsonProperty("b")]
        public string NombreProvincia { get; set; }  
    }
}

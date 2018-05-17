using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Provincia
    {
        [JsonProperty("a")]
        public string CodProvincia { get; set; }

        [JsonProperty("b")]
        public string CodPais { get; set; }

        [JsonProperty("c")]
        public string CodDepartamento { get; set; }
                
        [JsonProperty("d")]
        public string NombreProvincia { get; set; }        
    }
}

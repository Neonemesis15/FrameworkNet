using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Departamento
    {
        [JsonProperty("a")]
        public string CodDepartamento { get; set; }

        [JsonProperty("b")]
        public string CodPais { get; set; }

        [JsonProperty("c")]
        public string NombreDepartamento { get; set; }
    }
}

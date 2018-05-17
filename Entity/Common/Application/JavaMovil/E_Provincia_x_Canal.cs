using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Provincia_x_Canal
    {
        [JsonProperty("a")]
        public string codDepartamento { get; set; }

        [JsonProperty("b")]
        public string codProvincia { get; set; }

        [JsonProperty("c")]
        public string codCanal { get; set; }
    }

}

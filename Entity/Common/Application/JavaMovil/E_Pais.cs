using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Pais
    {
        [JsonProperty("a")]
        public string CodPais { get; set; }

        [JsonProperty("b")]
        public string NombrePais { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Segmento
    {
        [JsonProperty("a")]
        public string CodSegmento { get; set; }

        [JsonProperty("b")]
        public string NombreSegmento { get; set; }
    } 
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Competidora
    {
        [JsonProperty("a")]
        public string CodCompetidora { get; set; }

        [JsonProperty("b")]
        public string NombreCompetidora { get; set; }
    }
}

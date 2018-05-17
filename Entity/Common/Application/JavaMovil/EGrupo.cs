using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EGrupo
    {
        [JsonProperty("t")]
        public int Tabla { get; set; }

        [JsonProperty("k")]
        public string CodigoRelacion { get; set; }

        [JsonProperty("c")]
        public string Codigo { get; set; }

        [JsonProperty("d")]
        public string Descripcion { get; set; }
    }
}

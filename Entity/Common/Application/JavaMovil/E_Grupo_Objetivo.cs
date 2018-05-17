using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Grupo_Objetivo
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodGrupoObjetivo { get; set; }

        [JsonProperty("c")]
        public string NombreGrupoObjetivo { get; set; }
    }
}

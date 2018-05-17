using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Perfil
    {
        [JsonProperty("a")]
        public string Cod_TPerfil { get; set; }
        [JsonProperty("b")]
        public string Cod_Perfil { get; set; }
        [JsonProperty("c")]
        public string Cod_Equipo { get; set; }
        [JsonProperty("d")]
        public string Per_Descripcion { get; set; }
    }
}

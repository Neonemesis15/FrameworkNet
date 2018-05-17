using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_TPerfil
    {
        [JsonProperty("a")]
        public string Cod_TPerfil { get; set; }
        [JsonProperty("b")]
        public string TPerfil_Descripcion { get; set; }

    }
}

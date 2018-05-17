using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Tipo_Material_POP
    {
        [JsonProperty("a")]
        public string Codigo { get; set; }

        [JsonProperty("b")]
        public string Descripcion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Obj_Marca
    {
        [JsonProperty("a")]
        public string CodPtoVenta { get; set; }

        [JsonProperty("b")]
        public string CodMarca { get; set; }

        [JsonProperty("c")]
        public string NombreMarca { get; set; }

        [JsonProperty("d")]
        public string Objetivo { get; set; }

        [JsonProperty("e")]
        public string Cantidad { get; set; }

        [JsonProperty("f")]
        public string CodCategoria { get; set; }
    }
}

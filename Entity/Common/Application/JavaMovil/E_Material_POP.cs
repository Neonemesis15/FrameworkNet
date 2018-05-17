using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Material_POP
    {
        [JsonProperty("a")]
        public string PtoVenta { get; set; }

        [JsonProperty("b")]
        public string CodTipoMaterial { get; set; }

        [JsonProperty("c")]
        public string CodPOP { get; set; }

        [JsonProperty("d")]
        public string DescPOP { get; set; }

        [JsonProperty("e")]
        public string Propio { get; set; }
    }
}

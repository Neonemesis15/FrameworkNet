using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Foto
    {
        [JsonProperty("a")]
        public string nombreFoto { get; set; }
    }
}

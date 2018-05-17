using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_FotoAndroid
    {
        [JsonProperty("nom")]
        public string nombre { get; set; }

        [JsonProperty("fil")]
        public string file { get; set; }
    }
}

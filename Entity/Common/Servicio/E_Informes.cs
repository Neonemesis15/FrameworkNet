using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Informes
    {
        [JsonProperty("a")]
        public List<E_Informesv2> listainformes { get; set; }
        [JsonProperty("b")]
        public List<E_Informesv2> listanios { get; set; }
    }
}

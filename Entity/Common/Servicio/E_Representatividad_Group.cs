using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Representatividad_Group
    {
        [JsonProperty("a")]
        public E_Representatividad_Base representatividadProvincia { get; set; }

        [JsonProperty("b")]
        public E_Representatividad_Base representatividadSector { get; set; }

        [JsonProperty("c")]
        public E_Representatividad_Base representatividadDistrito { get; set; }
    }

    public class E_Representatividad_Base
    {
        [JsonProperty("a")]
        public string nombre { get; set; }

        [JsonProperty("b")]
        public int cantidad { get; set; }

        [JsonIgnore()]
        public int posicion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.EAPro
{
    public class E_Sala
    {
        [JsonProperty("a")]
        public string codigo { get; set; }

        [JsonProperty("b")]
        public string descripcion { get; set; }

        [JsonProperty("c")]
        public int capacidad { get; set; }

        [JsonProperty("d")]
        public int area { get; set; }

        [JsonProperty("e")]
        public double largo { get; set; }

        [JsonProperty("f")]
        public double ancho { get; set; }

        [JsonProperty("g")]
        public double alto { get; set; }
        
        [JsonProperty("h")]
        public int piso { get; set; }
    }
}
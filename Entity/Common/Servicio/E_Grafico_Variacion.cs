using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Grafico_Variacion
    {
        [JsonProperty("a")]
        public string idElemento { get; set; }

        [JsonProperty("b")]
        public string nombreElemento { get; set; }

        [JsonProperty("c")]
        public string ventas { get; set; }

        [JsonProperty("d")]
        public string anio { get; set; }

        [JsonProperty("e")]
        public string mes { get; set; }

        [JsonProperty("f")]
        public string periodo { get; set; }

        [JsonProperty("g")]
        public string descripcion { get; set; }

        [JsonProperty("h")]
        public string orden { get; set; }
    }

    public class E_Grafico_Variacion_New
    {
        [JsonProperty("a")]
        public string idElemento { get; set; }

        [JsonProperty("b")]
        public string nombreElemento { get; set; }

        [JsonProperty("c")]
        public string ventas { get; set; }

        [JsonProperty("d")]
        public string anio { get; set; }

        [JsonProperty("e")]
        public string mes { get; set; }

        [JsonProperty("f")]
        public string periodo { get; set; }

        [JsonProperty("g")]
        public string descripcion { get; set; }
    }
}

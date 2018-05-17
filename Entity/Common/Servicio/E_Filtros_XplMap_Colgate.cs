using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Filtros_XplMap_Colgate
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDepartamento { get; set; }

        [JsonProperty("f")]
        public string codProvincia { get; set; }

        [JsonProperty("g")]
        public string codZona { get; set; }

        [JsonProperty("h")]
        public string codDistrito { get; set; }

        [JsonProperty("i")]
        public string codCategoria { get; set; }

        [JsonProperty("j")]
        public string codProducto { get; set; }

        [JsonProperty("k")]
        public string codCluster { get; set; }

        [JsonProperty("l")]
        public string anio { get; set; }

        [JsonProperty("m")]
        public string mes { get; set; }

        [JsonProperty("n")]
        public string codPeriodo { get; set; }

        [JsonProperty("o")]
        public string codOpcion { get; set; }
    }
}

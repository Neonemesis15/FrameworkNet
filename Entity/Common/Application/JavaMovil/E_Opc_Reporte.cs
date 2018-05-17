using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Opc_Reporte
    {
        [JsonProperty("a")]
        public int CodReporte { get; set; }

        [JsonProperty("b")]
        public int CodSubReporte { get; set; }

        [JsonProperty("c")]
        public int VistaCategoria { get; set; }

        [JsonProperty("d")]
        public int VistaSubCategoria { get; set; }

        [JsonProperty("e")]
        public int VistaMarca { get; set; }

        [JsonProperty("f")]
        public int VistaSubMarca { get; set; }

        [JsonProperty("g")]
        public int VistaPresentacion { get; set; }

        [JsonProperty("h")]
        public int VistaFamilia { get; set; }

        [JsonProperty("i")]
        public int VistaSubFamilia { get; set; }

        [JsonProperty("j")]
        public int VistaProducto { get; set; }
    }
}

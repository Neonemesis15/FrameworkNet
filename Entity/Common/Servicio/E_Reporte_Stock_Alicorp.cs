using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Reporte_Stock_Alicorp
    {
        [JsonProperty("a")]
        public string Id_Familia { get; set; }
        [JsonProperty("b")]
        public string Fam_Nombre { get; set; }
        [JsonProperty("c")]
        public string Cantidad { get; set; }
        [JsonProperty("d")]
        public string Observacion { get; set; }
    }
}

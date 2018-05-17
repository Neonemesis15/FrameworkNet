using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    /// <summary>
    /// XPL - BD de Xplora
    /// UBI - Gestion de Ubigeo.
    /// Create  : Pablo Salas A.
    /// Date    : 22/07/2012
    /// Description: Entidad distribuidora para Xplora
    /// </summary>
    public class E_XPL_UBI_Distribuidora
    {
        [JsonProperty("a")]
        public string Id_Dex { get; set; }
        [JsonProperty("b")]
        public string Dex_Name { get; set; }
        [JsonProperty("c")]
        public string Dex_Status { get; set; }
        [JsonProperty("d")]
        public string Dex_CreateBy { get; set; }
        [JsonProperty("e")]
        public string Dex_DateBy { get; set; }
        [JsonProperty("f")]
        public string Dex_ModiBy { get; set; }
        [JsonProperty("g")]
        public string Dex_DateModiBy { get; set; }

    }
}

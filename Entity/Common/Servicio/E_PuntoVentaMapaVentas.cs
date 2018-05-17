using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PuntoVentaMapaVentas:E_PuntoVentaMapa
    {
        [JsonProperty("aa")]
        public string cluster { get; set; }

        [JsonProperty("ab")]
        public string color { get; set; }

        [JsonProperty("ac")]
        public string venta { get; set; }
    }
}

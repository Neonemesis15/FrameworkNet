using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Precio_Detalle
    {
        [JsonIgnore()]
        public string Id_reg_precio { get; set;} 
        
        [JsonProperty("a")]
        public string Id_producto { get; set; }
        
        [JsonProperty("b")]
        public string Precio_lista { get; set; }
        
        [JsonProperty("c")]
        public string Precio_reventa { get; set; }
        
        [JsonProperty("d")]
        public string Precio_oferta { get; set; }
        
        [JsonProperty("e")]
        public string Pvp { get; set; }
        
        [JsonProperty("f")]
        public string Precio_costo { get; set; }
        
        [JsonProperty("g")]
        public string Precio_regular { get; set; }
        
        [JsonProperty("h")]
        public string Precio_min { get; set; }
        
        [JsonProperty("i")]
        public string Precio_max { get; set; }

        [JsonProperty("j")]
        public string Precio_mayorista { get; set; }

        [JsonProperty("k")]
        public string Motivo_obs { get; set; }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    //Add 29/02/2012 pSalas
    public class E_Reporte_Precio
    {
        public E_Reporte_Precio() {
            PrecioDetalle = new List<E_Reporte_Precio_Detalle>();
        }

        [JsonProperty("a")]
        public string Person_id { get; set; }

        [JsonProperty("b")]
        public string Perfil_id { get; set; }
        
        [JsonProperty("c")]
        public string Equipo_id { get; set; }
        
        [JsonProperty("d")]
        public string Cliente_id { get; set; }
        
        [JsonProperty("e")]
        public string ClientePDV_Code { get; set; }

        [JsonProperty("f")]
        public string Categoria_id { get; set; }
        
        [JsonProperty("g")]
        public string Marca_id { get; set; }
        
        [JsonProperty("h")]
        public string Tipo_Canal { get; set; }
        
        [JsonProperty("i")]
        public string FechaRegistro { get; set; }
        
        [JsonProperty("j")]
        public string Latitud { get; set; }
        
        [JsonProperty("k")]
        public string Longitud { get; set; }
        
        [JsonProperty("l")]
        public string OrigenCoordenada { get; set; }
        
        [JsonProperty("m")]
        public string Observacion { get; set; }
        
        [JsonProperty("n")]
        public string Id_familia { get; set; }
        
        [JsonProperty("o")]
        public string Id_subfamilia { get; set; }
         
        [JsonProperty("p")]
        public string Tipo_precio { get; set; }

        [JsonProperty("q")]
        public List<E_Reporte_Precio_Detalle> PrecioDetalle { get; set; }   

    }
}

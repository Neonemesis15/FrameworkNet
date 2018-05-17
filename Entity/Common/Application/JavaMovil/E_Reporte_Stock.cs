using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Stock
    {
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
        public string Categoria { get; set; }
        [JsonProperty("g")]
        public string Marca { get; set; }
        [JsonProperty("h")]
        public string ProductFamily { get; set; }
        [JsonProperty("i")]
        public string ProductSubFamily { get; set; }
        [JsonProperty("j")]
        public string FechaRegistro { get; set; }
        [JsonProperty("k")]
        public string Latitud { get; set; }
        [JsonProperty("l")]
        public string Longitud { get; set; }
        [JsonProperty("m")]
        public string OrigenCoordenada { get; set; }
        [JsonProperty("n")]
        public string Observacion { get; set; }
        [JsonProperty("o")]
        public List<E_Reporte_Stock_Detalle> StockDetalle{get;set;}
    }
}

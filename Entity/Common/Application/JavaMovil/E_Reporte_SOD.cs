using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_SOD
    {
        [JsonProperty("a")]
        public string Person_id{get;set;}
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
        public string FechaRegistro { get; set; }
        [JsonProperty("h")]
        public string Latitud { get; set; }
        [JsonProperty("i")]
        public string Longitud { get; set; }
        [JsonProperty("j")]
        public string OrigenCoordenada { get; set; }
        [JsonProperty("k")]
        public string Observacion { get; set; }
        [JsonProperty("l")]
        public List<E_Reporte_SOD_Detalle> Detalle { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Exhibicion
    {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
        [JsonProperty("b")]
        public string CodPerfil { get; set; }
        [JsonProperty("c")]
        public string CodCampania { get; set; }
        [JsonProperty("d")]
        public string codCompania { get; set; }
        [JsonProperty("e")]
        public string codPDV { get; set; }
        [JsonProperty("f")]
        public string CodCategoria { get; set; }
        [JsonProperty("g")]
        public string CodMarca { get; set; }
        [JsonProperty("h")]
        public string CodCondicion { get; set; }
        [JsonProperty("i")]
        public string FechaInicio { get; set; }
        [JsonProperty("j")]
        public string FechaFin { get; set; }
        [JsonProperty("k")]
        public string FechaBD { get; set; }
        [JsonProperty("l")]
        public string Latitud { get; set; }
        [JsonProperty("m")]
        public string Longitud { get; set; }
        [JsonProperty("n")]
        public string Origen { get; set; }
        [JsonProperty("o")]
        public List<E_Reporte_Exhibicion_Detalle> Detalle { get; set; }
    }

    public class E_Reporte_Exhibicion_Detalle { 
        [JsonProperty("a")]
        public string Id_Tipo{get;set;}
        [JsonProperty("b")]
        public string Cantidad{get;set;}
        [JsonProperty("c")]
        public string Cod_Categoria{get;set;}
    }
}

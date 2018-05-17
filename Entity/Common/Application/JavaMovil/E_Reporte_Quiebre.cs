﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Quiebre
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
        public DateTime FechaBD { get; set; }
        [JsonProperty("i")]
        public string Latitud { get; set; }
        [JsonProperty("j")]
        public string Longitud { get; set; }
        [JsonProperty("k")]
        public string Origen { get; set; }
        [JsonProperty("l")]
        public List<E_Reporte_Quiebre_Detalle> Detalle { get; set; }
    }
    
    public class E_Reporte_Quiebre_Detalle {
        [JsonProperty("a")]
        public string CodProducto { get; set; }
        [JsonProperty("b")]
        public string Quiebre { get; set; }
    }
}   
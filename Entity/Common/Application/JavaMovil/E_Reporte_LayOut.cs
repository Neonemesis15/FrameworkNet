using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_LayOut
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
        public string Objetivo { get; set; }
        [JsonProperty("i")]
        public string Cantidad { get; set; }
        [JsonProperty("j")]
        public string Frentes { get; set; }
        [JsonProperty("k")]
        public DateTime FechaBD { get; set; }
        [JsonProperty("l")]
        public string Latitud { get; set; }
        [JsonProperty("m")]
        public string Longitud { get; set; }
        [JsonProperty("n")]
        public string Origen { get; set; }
        [JsonProperty("o")]
        public string Observacion { get; set; }

    }
}

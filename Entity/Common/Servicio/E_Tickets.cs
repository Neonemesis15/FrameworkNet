using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Tickets
    {
        [JsonProperty("a")]
        public string Cod_Tickets { get; set; }
        [JsonProperty("b")]
        public string Solicitante { get; set; }
        [JsonProperty("c")]
        public string Telefono { get; set; }
        [JsonProperty("d")]
        public string Email { get; set; }
        [JsonProperty("f")]
        public int Cod_Categoria { get; set; }
        [JsonProperty("g")]
        public string Nombre_Categoria { get; set; }
        [JsonProperty("h")]
        public int Cod_Area { get; set; }
        [JsonProperty("i")]
        public string Nombre_Area { get; set; }
        [JsonProperty("j")]
        public int Tipo { get; set; }
        [JsonProperty("k")]
        public string Nombre_Tipo { get; set; }
        [JsonProperty("l")]
        public int Id_Prioridad { get; set; }
        [JsonProperty("m")]
        public string Nombre_Prioridad { get; set; }
        [JsonProperty("n")]
        public string Asunto { get; set; }
        [JsonProperty("o")]
        public string Descripcion { get; set; }
        [JsonProperty("p")]
        public string OBS { get; set; }
        [JsonProperty("q")]
        public string Asignado { get; set; }
        [JsonProperty("r")]
        public DateTime Fecha_Registro { get; set; }
        [JsonProperty("s")]
        public string Creado_Por { get; set; }
        [JsonProperty("t")]
        public string Modificado_Por { get; set; }
        [JsonProperty("u")]
        public DateTime Fecha_Modificacion { get; set; }
    }
}

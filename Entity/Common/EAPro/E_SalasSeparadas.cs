using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.EAPro
{
    public class E_SalasSeparadas
    {
        [JsonProperty("a")]
        public string codigo { get; set; }

        [JsonProperty("b")]
        public string codigoSala { get; set; }

        [JsonProperty("c")]
        public string nombreSala { get; set; }

        [JsonProperty("d")]
        public string codigoUsuario { get; set; }

        [JsonProperty("e")]
        public string nombreUsuario { get; set; }

        [JsonProperty("f")]
        public string codigoEncargado { get; set; }

        [JsonProperty("g")]
        public string nombreEncargado { get; set; }

        [JsonProperty("h")]
        public string codigoCentroCosto { get; set; }

        [JsonProperty("i")]
        public string nombreCentroCosto { get; set; }

        [JsonProperty("j")]
        public string descripcion { get; set; }

        [JsonProperty("k")]
        public string adicionales { get; set; }

        [JsonProperty("l")]
        public string cantidad { get; set; }

        [JsonProperty("m")]
        public string fecha { get; set; }

        [JsonProperty("n")]
        public string horaInicio { get; set; }

        [JsonProperty("o")]
        public string horaFin { get; set; }

        [JsonProperty("p")]
        public string estado { get; set; }

        [JsonProperty("q")]
        public string creadoPor { get; set; }

        [JsonProperty("r")]
        public string fechaCreacion { get; set; }

        [JsonProperty("s")]
        public string modificadoPor { get; set; }

        [JsonProperty("t")]
        public string fechaModificacion { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Descripcion     : Entidad Visita para App Movil Movistar
    /// Fecha           : 18/05/2012 PSA
    /// </summary>
    public class E_Visita_Mov
    {
        [JsonProperty("a")]
        public int Cod_Persona { get; set; }
        [JsonProperty("b")]
        public string Cod_Equipo { get; set; }
        [JsonProperty("c")]
        public int Cod_Compania { get; set; }
        [JsonProperty("d")]
        public string Cod_PtoVenta { get; set; }
        [JsonProperty("e")]
        public string Cod_NoVisita { get; set; }
        [JsonProperty("f")]
        public string Fec_RegistroInicio { get; set; }
        [JsonProperty("g")]
        public string Latitud_Inicio { get; set; }
        [JsonProperty("h")]
        public string Longitud_Inicio { get; set; }
        [JsonProperty("i")]
        public string Origen_Inicio { get; set; }
        [JsonProperty("j")]
        public string Fec_RegistroFin { get; set; }
        [JsonProperty("k")]
        public string Latitud_Fin { get; set; }
        [JsonProperty("l")]
        public string Longitud_Fin { get; set; }
        [JsonProperty("m")]
        public string Origen_fin { get; set; }
        /// <summary>
        /// Nombre de Foto de No Visita para San Fernando Tradicional.
        /// </summary>
        [JsonProperty("n")]
        public string Nombre_Foto { get; set; }
        /// <summary>
        /// Author      : Pablo Salas A.
        /// Fecha       : 09/08/2012
        /// Descripcion : Comentario de Foto de No Visita para San Fernando Tradicional.
        /// </summary>
        [JsonProperty("o")]
        public string Comentario_Foto { get; set; }
    }
}

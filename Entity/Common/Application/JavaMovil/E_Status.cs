using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Author  : Pablo Salas A.
    /// Date    : 25/07/2012
    /// Descripcion: Maestro de Sincronización para el SubReporte de Status del Reporte Incidencias
    ///              Cliente San Fernando - Canal Tradicional
    /// </summary>
    public class E_Status
    {
        [JsonProperty("a")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("b")]
        public string Cod_Status { get; set; }
        [JsonProperty("c")]
        public string Sta_Nombre { get; set; }
    }
}

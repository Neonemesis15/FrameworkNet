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
    /// Descripcion: Maestro de Sincronización para el SubReporte de Incidencia del Reporte Incidencias
    ///              Cliente San Fernando - Canal Tradicional
    /// </summary>
    public class E_Incidencia
    {
        [JsonProperty("a")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("b")]
        public string Cod_Incidencia { get; set; }
        [JsonProperty("c")]
        public string Inc_Descripcion { get; set; }
        [JsonProperty("d")]
        public int Flg_Cantidad { get; set; }
    }
}

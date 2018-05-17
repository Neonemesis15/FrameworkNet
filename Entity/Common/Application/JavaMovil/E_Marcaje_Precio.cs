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
    /// Descripcion: Maestro de Sincronización para el Reporte de Marcaje de Precio
    ///              Cliente San Fernando - Canal Tradicional
    /// </summary>
    public class E_Marcaje_Precio
    {
        [JsonProperty("a")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("b")]
        public string Cod_Marcaje_Precio { get; set; }
        [JsonProperty("c")]
        public string MPre_Nombre { get; set; }

    }
}

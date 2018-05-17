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
    /// Descripcion: Maestro de Sincronización para el Reporte de Asesoramiento de Productos
    ///              Cliente San Fernando - Canal Tradicional
    /// </summary>
    public class E_Capacitacion
    {
        [JsonProperty("a")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("b")]
        public string Cod_Capacitacion { get; set; }
        [JsonProperty("c")]
        public string Cap_Nombre { get; set; }
    }
}

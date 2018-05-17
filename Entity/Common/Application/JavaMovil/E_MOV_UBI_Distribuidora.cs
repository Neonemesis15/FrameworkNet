using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{

    /// <summary>
    /// MOV - Movil
    /// UBI - Gestión de Ubigeo
    /// Create  : Pablo Salas Alvarez
    /// Date    : 22/07/2012
    /// Description: Entidad para Distribuidora BD Intermedia.
    /// </summary>
    public class E_MOV_UBI_Distribuidora
    {
        [JsonProperty("a")]
        public string Cod_Distribuidora { get; set; }
        [JsonProperty("b")]
        public string Dis_Nombre { get; set; }
        [JsonProperty("c")]
        public string Estado { get; set; }

    }
}

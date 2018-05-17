using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_ReporteCliente_Stock_Validacion
    {
        public E_ReporteCliente_Stock_Validacion()
        {
            oListReporteCliente_Stock_Validacion_Detalle = new List<E_ReporteCliente_Stock_Validacion_Detalle>();
        }

        [JsonProperty("a")]
        public double totalDiasGiro { get; set; }
        [JsonProperty("b")]
        public List<E_ReporteCliente_Stock_Validacion_Detalle> oListReporteCliente_Stock_Validacion_Detalle { get; set; }

    }
    public class E_ReporteCliente_Stock_Validacion_Detalle
    {
        [JsonProperty("a")]
        public string codPdv { get; set; }
        [JsonProperty("b")]
        public string nombrePdv { get; set; }
        [JsonProperty("c")]
        public string diasGiro { get; set; }
        [JsonProperty("d")]
        public string validacion { get; set; }
    }
}

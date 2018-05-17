using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class ESincronizarAuditoria
    {
        [JsonProperty("p")]
        public List<ECliente> ListaCliente { get; set; }

        [JsonProperty("r")]
        public List<EReporteAuditoria> ListaReporte { get; set; }

        [JsonProperty("c")]
        public List<ECanal> listaCanal { get; set; }

        [JsonProperty("m")]
        public List<EPuntoVentaAuditoria> listaPtoVenta { get; set; }
        
        [JsonProperty("e")]
        public List<EEstado> listaEstado { get; set; }

        [JsonProperty("o")]
        public List<EMotivo> listaMotivo { get; set; }

        [JsonProperty("t")]
        public List<EParametro> listaParametro { get; set; }
    }
}
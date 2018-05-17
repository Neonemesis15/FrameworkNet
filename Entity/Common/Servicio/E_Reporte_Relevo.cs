using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Reporte_Relevo
    {
        [JsonProperty("a")]
        public string codigoGestor { get; set; }

        [JsonProperty("b")]
        public string nombreGestor { get; set; }

        [JsonProperty("c")]
        public string objetivoDiario { get; set; }

        [JsonProperty("d")]
        public string pdvVisitado { get; set; }

        [JsonProperty("e")]
        public string pdvRelevo { get; set; }

        [JsonProperty("f")]
        public string cumplimientoValor { get; set; }

        [JsonProperty("g")]
        public string cumplimientoColor { get; set; }

        [JsonProperty("h")]
        public string pdvNuevo { get; set; }
    }
}
